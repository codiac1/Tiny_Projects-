// SPDX-License-Identifier: MIT
pragma solidity ^0.8.0;

contract EventContract{
    struct Event {
        string name ;
        address organiser;
        uint date; //date use should provide in the form of a timestamp
        uint ticketPrice;
        uint ticketCount;
        uint remainTicket;
    }

    mapping(uint => Event) public events;
    mapping(address => mapping(uint => uint)) public tickets;

    uint public nextId;

    function createEvent(uint date , string memory name , uint price , uint ticketCount) external {
        require (date > block.timestamp , "not a Valid date");
        require (ticketCount > 0 , "not enough tickets");

        //adding an event to events mapping
        events[nextId] = Event(name , msg.sender , date , price, ticketCount, ticketCount );
        nextId++;
    }

    modifier Valid(uint eventId){
        require(events[eventId].date != 0 , "This event does not exict");
        require(events[eventId].date > block.timestamp , "This event has expired");
        _;
    }
    // now buy tickets  

    function buytickets(uint eventId , uint noOfTickets) external payable Valid(eventId){
        Event storage _event = events[eventId];
        
        require(_event.ticketCount >= noOfTickets , "Not enough tickets available");
        require(msg.value == _event.ticketPrice * noOfTickets , "Not enough amount provided");

        _event.ticketCount -= noOfTickets;
        tickets[msg.sender][eventId] += noOfTickets;
        }

    //you can tranfer your tickets to a friend

    function transferTickets(uint eventId , uint noOfTickets , address target) external Valid(eventId){
        require(tickets[msg.sender][eventId] >= noOfTickets , "You don't have enough tickets");
        tickets[msg.sender][eventId] -= noOfTickets;
        tickets[target][eventId] += noOfTickets;
    }
}