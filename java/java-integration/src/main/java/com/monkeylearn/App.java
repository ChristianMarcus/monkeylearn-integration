package com.monkeylearn;

import com.mashape.unirest.http.Unirest;
import com.mashape.unirest.http.HttpResponse;
import com.mashape.unirest.http.JsonNode;
import com.mashape.unirest.http.exceptions.UnirestException;


public class App 
{
    public static void main( String[] args ) throws UnirestException
    {
    	HttpResponse<JsonNode> response = Unirest.post(
    		"http://app.monkeylearn.com/api/v1/categorizer/hDDngsX8/classify_text/"
    	)
		.header("Authorization", "token <YOUR TOKEN GOES HERE>")
		.field("text", "This is a text to try language detection.")
		.asJson();

		System.out.println(response.getCode());
        System.out.println(response.getHeaders());
        System.out.println(response.getBody());
    }
}
