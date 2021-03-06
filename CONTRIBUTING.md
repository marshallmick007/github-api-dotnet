## How to Contribute?

Pull requests are king!!

## Getting Started

Happy to receive any help I can get. This includes documents, bug reporting, issues, code, anything!

* If you're submitting an issue:
	* Make sure the issue doesn't already exist
	* Clearly describe (with as much detail as you can) the issue including steps to reproduce if possible
* Fork the repo (using the button on the top right on GitHub)
* You can build the project using Visual Studio. Currently, I'm using VS 2012 Update 3

This project is using [RestSharp](http://restsharp.org/) for handling communication with GitHub and [xUnit](http://xunit.codeplex.com/) for testing. NuGet Package Restore is on, so you should get these packages on the first build.

## Running the Tests

This project uses `unit tests` to ensure that the requests are setup correctly and `integration tests` to verify correct responses from the API. In order to run the integration tests, you'll need to create an App.config file in the `GitHub.APIIntegrationTests` project with the following settings:

	<appSettings>
	    <add key="GITHUB_API_USERNAME" value="YOUR_GITHUB_USERNAME"/>
	    <add key="GITHUB_API_PASSWORD" value="YOUR_GITHUB_PASSWORD"/>
		<add key="GITHUB_API_TOKEN" value="YOUR_PERSONAL_API_ACCESS_TOKEN"/>
	</appSettings>

You can create a Personal API Access Key here: <https://github.com/settings/applications>.

__*This file has been added to `.gitignore` so your password/token will never be checked-in or shared.*__

## Making Changes

* Create a topic branch off master (NEVER work directly on master)
* Make commits for logical units (small but complete features/fixes)
* Provide clear comments (preferrably in the present tense for readability)
* Ensure you've added unit and integration tests for your commits and that you've run __*ALL*__ tests before committing

## Submitting Changes

* Push your changes up to a remote topic branch on your fork
* Submit a pull request (if you can, note which issue/bug/feature it's for)

### Things to Note

Pull requests will not be accepted without associated tests. These tests should exercise the new functionality. Specifically, they should fail without your pull request and (obviously) pass with it. Tests should follow [this guideline](http://haacked.com/archive/2012/01/01/structuring-unit-tests.aspx) whenever possible.

Remember to update any documentation, comments, guides, etc. that are affected by/related to your changes.