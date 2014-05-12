<?php

require_once 'unirest-php/lib/Unirest.php';

$response = Unirest::post(
	"http://app.monkeylearn.com/api/v1/categorizer/hDDngsX8/classify_text/",
	array(
		"Authorization" => "token <YOUR TOKEN GOES HERE>"
	),
	array(
		"text" => "This is a text to try language detection."
	)
);

print_r($response->code);
print_r($response->headers);
print_r($response->body);

?> 
