$form = new \API\Entities\Order();
$form->setMessage("Hello World!");
try {
    $pet = $client->order()->post($form);
} catch (UnprocessableEntityException $e) {
    var_dump($e->getErrors());
}
