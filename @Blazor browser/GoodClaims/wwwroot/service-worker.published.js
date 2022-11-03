self.importScripts('./service-worker-assets.js');
self.addEventListener('install', event => event.waitUntil(onInstall(event)));
self.addEventListener('activate', event => event.waitUntil(onActivate(event)));
self.addEventListener('fetch', event => event.respondWith(onFetch(event)));
const cacheName = `${cacheNamePrefix}${self.assetsManifest.version}`;
async function onInstall(event) {
    await caches.open(cacheName).then(cache => cache.addAll(self.assetsManifest.assets
        .filter(asset => [/\.dll$/, /\.pdb$/, /\.wasm/, /\.html/, /\.js$/, /\.json$/, /\.css$/, /\.woff$/, /\.png$/, /\.jpe?g$/, /\.gif$/, /\.ico$/, /\.blat$/, /\.dat$/].some(pattern => pattern.test(asset.url)))
        .filter(asset => ![/^service-worker\.js$/].some(pattern => pattern.test(asset.url)))
        .map(asset => new Request(asset.url, { integrity: asset.hash, cache: 'no-cache' }))));
}
async function onActivate(event) {
    await Promise.all((await caches.keys())
        .filter(key => key.startsWith('offline-cache-') && key !== cacheName)
        .map(key => caches.delete(key)));
}
async function onFetch(event) {
    if (event.request.method === 'GET') {
        const cache = await caches.open(cacheName);
        return await cache.match(event.request.mode === 'navigate' ? 'index.html' : event.request);
    }
    return fetch(event.request);
}