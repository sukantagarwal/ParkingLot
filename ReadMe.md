# Parking Lot

To perform hands-on on using LiteDb and dapper to implement concept of NoSQL Document store.

The problem statement is that of a parking lot following the below constraints - 
1. The parking lot is made up of levels. This should be configured when creating a new parking lot.
2. Each level should contain parking spaces. This should be configured when creating the parking lot and the number of parking space must be same for each level. However the configuration of the parking spaces can be different for the levels.
3. The parking space can be of 2 types - (1) Small and (2) Large.
4. Small parking space is for bikes.
5. Large Parking space is for cars.
6. three consecutive large parking spaces can be used to park a bus.
7. Lowest level should be filled first.
8. Exact space should be preferred first, thereby overriding contraint nunmber 7.

The following operations should be performed - 
1. The vehicle should be given a parking when asked for. If no space is available, the parking should be denied.

Version 2 of this app is to include below constraints - 
1. A service keeps generating vehicle to seek parking and keeps "un-parking" vehicles at random time.
2. When the vehicle requests for parking, the parking is seeked for a time slot of 2 hours.
3. A service keeps a tab on parking by addressing the parking request, un-parking request, calculating money.

Version 3 of this app deals with ecomonics of running a parking lot
1. A service keeps a tab on the economy of the parking lot. Income is from parking charges, expenses are rent and electricity.