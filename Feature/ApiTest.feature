Feature: JSONPlaceholder API Operations
  As a developer
  I want to test the JSONPlaceholder API
  So that I can verify the CRUD operations

  Scenario: Retrieve a list of posts
    Given I have the JSONPlaceholder API endpoint for posts
    When I send a GET request to the endpoint
    Then I receive a response with status code 200
    And the response should contain a list of posts
    And each post in the response should have an id, title, and body

  # Scenario: Create a new post
  #   Given I have the JSONPlaceholder API endpoint for posts
  #   And I have a new post payload with title "New Post" and body "This is a new post."
  #   When I send a POST request to the endpoint with the payload
  #   Then I receive a response with status code 201
  #   And the response should contain the created post
  #   And the post in the response should have the correct title and body

  # Scenario: Update an existing post
  #   Given I have the JSONPlaceholder API endpoint for posts
  #   And I have an existing post with id 1
  #   And I have an updated post payload with title "Updated Post" and body "This post has been updated."
  #   When I send a PUT request to the endpoint with the updated payload
  #   Then I receive a response with status code 200
  #   And the response should contain the updated post
  #   And the post in the response should have the updated title and body

  # Scenario: Delete an existing post
  #   Given I have the JSONPlaceholder API endpoint for posts
  #   And I have an existing post with "id"
  #   When I send a DELETE request to the endpoint
  #   Then I receive a response with status code 200
  #   And the response should be empty

