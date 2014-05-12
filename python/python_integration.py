import unirest

response = unirest.post("http://app.monkeylearn.com/api/v1/categorizer/hDDngsX8/classify_text/",
	headers={
		"Authorization": "token <YOUR TOKEN GOES HERE>"
	},
	params={
		"text": "This is a text to try language detection."
	}
)

print response.code
print response.headers
print response.body

