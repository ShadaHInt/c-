Feature: APIDemo

A short summary of the feature

@get_api
Scenario:  Get the list of users in Page 2
	Given User set the Get User Endpoint
	When User send GET Request
	Then User verfies the page number and first name in response


	@post_api
Scenario:  Add a user record
	Given User set the Post User Endpoint
	When User provides payload
	When user send POST Request
	Then User verfies if correct name and jobid recieved in response

		@put_api
Scenario: Update a user record
	Given User set the Put User Endpoint
	When User provides payload to update jobid
	When user send PUT Request
	Then User verfies the jobid in response

	@delete_api
Scenario: Delete a user record
	Given User set the Delete User Endpoint
	When user send DELETE Request
	Then User verfies the status code in response




	