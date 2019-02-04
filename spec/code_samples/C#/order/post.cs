API.v1.Order order = new API.v1.Order();
order.message = "Hello World!");
OrderResponse response = order.post();
if (response.statusCode == HttpStatusCode.Created)
{
  // Success
}
else
{
  // Something wrong -- check response for errors
  Console.WriteLine(response.getRawResponse());
}
