# Proxy

Proxy is a structural design pattern that provides a substitute or placeholder for another object.

## When to use

* Lazy initialization for when having a heavyweight service object which is wasting system resources by being always up, even though it's only needed from time to time.
* Access control for when only specific clients needs to be able to use the service object.
* Local execution of a remote service for when the service object is located on a remote server.
* Logging requests for when it's desired to keep a history of requests to the service object.
* Caching request results for when cache results of client requests and the manage of the life cycle of this cache is desired.
* Smart reference for when a heavyweight object needs to be dismissable once there are no clients using it anymore.

## Pros

* Possible to control the service object without clients knowing about it.
* Possible to manage the lifecycle of the service object when clients don’t care about it.
* The proxy works even if the service object isn’t ready or is not available.
* Open/Closed Principle. Introduction of new proxies without changing the service or clients.

## Cons

* The code may become more complicated due to introduction of a lot new classes.
* The response from the service might get delayed.

## Output

```
HTTP API Service
HTTP API Client
{"Key":"Value"}

HTTP API Service
{"Key":"Value"}
```
