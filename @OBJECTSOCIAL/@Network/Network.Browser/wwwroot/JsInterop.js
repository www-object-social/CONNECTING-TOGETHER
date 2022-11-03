export function Constructor(obj) {
    window.addEventListener("online", () => obj.invokeMethod("Online"))
    window.addEventListener("offline", () => obj.invokeMethod("Offline"))
    return navigator.onLine;
}
