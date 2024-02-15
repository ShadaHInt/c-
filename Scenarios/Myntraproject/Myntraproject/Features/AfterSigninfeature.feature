Feature: AfterSigninfeature

Operations

@Aftersigncolor
Scenario: After signincolor
	Given navigated to the myntra homepage
	When user navigate to kurti and suits subcategory of women category
	Then pick a color from it

@Aftersignbrand
Scenario: After signinbrand
    Given navigated to the myntra homepage
	When user navigate to casual shirt subcategory of men category
	Then pick a brand from it

@Aftersignprice
Scenario: After signinprice
    Given navigated to the myntra homepage
	When user navigate to tshirt subcategory of kids category
	Then pick a price range from it
