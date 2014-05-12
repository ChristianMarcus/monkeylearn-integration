require 'unirest'

response = Unirest::post "http://app.monkeylearn.com/api/v1/categorizer/hDDngsX8/classify_text/", 
	headers: { 
		"Authorization" => "token <YOUR TOKEN GOES HERE>"
	},
	parameters: { 
		:text => "This is a text to try language detection."
	}

puts response.code
puts response.headers
puts response.body

