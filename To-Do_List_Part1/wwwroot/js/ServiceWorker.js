const CACHE_NAME = "statci_cache";
const STATIC_ASSETS = [
    '/index.html',
    '/css/style.css',
    '/js/site.js'
]

async function preCache() {
    const cache = await caches.open(CACHE_NAME);
    return cache.addAll(STATIC_ASSETS);
}

self.addEventListener('install', event => {
    console.log("sw installed");
    event.waitUntill(preCache());
})

async function cleanipCache() {
    const keys = await caches.keys();
    const keysToDelete = key.map(key => {
        if (key !== CACHE_NAME) {
            return caches.delete(key);
        }
    })
}

self.addEventListener('activate', event => {
    console.log("sw activated");
    alert("hii");
})

async function fetchAssets(event) {
    try {
        const response = await fetch(event.request);
        return response;
    } catch (err) {
        const cache = await caches.open(CACHE_NAME)
        return cache.match(event.request);
    }
}

self.addEventListener('fetch', event => {
    console.log("sw fetched");
    event.respondWith(fetchAssets(event));
})