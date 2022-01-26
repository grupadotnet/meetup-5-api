const makeHttpRequest = (url, options) => fetch(url, options).then(response => response.json());

export const getData = (url, options) => makeHttpRequest(url, { method: "GET", ...options });

export const deleteData = (url, options) => makeHttpRequest(url, { method: "DELETE", ...options });