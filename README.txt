Time tracking:
June 11 20:13 - Start design doc.
June 11 20:51 - Start preparing repo and project
June 11 21:02 - Project is setup implementing...


Time budget:
- design: 20-30 minutes
- project setup: 10 minutes
- implementation: 60-90 minutes
- clean up: 30 minutes

Actual time:
- design: 38ish minutes


Reiterate requirements in brief format:
	Purpose of system: Motel Booking System
	Constraints:
		- Handicap is limited to rooms on the first floor
		- Pets are limited to rooms on the first floor
		- Room rate varies based on number of beds
			- 1 bed -> $50/night
			- 2 bed -> $75/night
			- 3 bed -> $90/night
		- Pets add additional fee to rate
			- $20/pet


Assumptions:
	A motel booking is a reservation.
	A stay is a separate thing may or may not make it into the project.

My design thoughts:
	Make rooms read from a configuration system
		- rooms should be handicap or not based on config system instead of floor number this allows for a more generic system at little development time cost.
		- configurations system can be hard coded at first until there is time to create a real implementation.

	Reservation availability:
		Check stored reservations and make sure all days are available with the specified room type.

	Pet count is mostly important for telling what the room rate is, after the rate is calculated we don't need to know an amount. (until we want to make a bill)


	Reservation storage:
		Add - Store room spec and dates.
		Remove - store negative room spec and dates.
		Aggregate periodically -> also this can be when unused reservations are charged

	Stay storage:
		Check in: assign room and store check in record
		Check out: clear room and assign clean up crew



Things:
	Room spec:
		Features: List<Features>
		
	Reservation:
		Guest Id
		Features: List<Features>
		Check In
		Check Out

	Check In:
		Guest Id
		Room spec  // for calculating the bill
		Room Id
		Date

	Check Out:
		Guest Id
		Date
		
	Features:
		Feature Name
		Feature Cost

	Guest identification:
		guest id
		guest name




Out of scope:
	Room assignments - this is done at check-in time and is another very interesting exercise.
	Overbooking - most hotels will allow for over booking.  Statistics should be kept allowing for tracking and estimating how many reservations will be canceled or not used, but that is out of scope for this project.
	Overlapping bookings, this is part of room assignments. A naive system can easily get a hotel in trouble but we are going to explicitly not worry about that at this time, that will wait for the next iteration.
	Discounting/Membership programs - This is specifically out of scope, there will only be the rack rate, nothing else.
	Out of service rooms - rooms may be unavailable for any number of reasons (maintenance, repair, crime scene, etc.)  This is out of scope.


