# Implementation Planning Exercise (4 marks)

Given the following user-interface, document your implementation plan for the **complete functionality** of this form. 
Follow the guidance and examples given by your instructor for your implementation plan. The form is designed to collect a 
picking information for a customer's order. Remember that the entire form will be processed as a single transaction in the BLL.

![picking sheet data](./OrderPickingSheet.png)

Note the following requirements when processing in the BLL:

Fetch

- Order number and Picker ID are required

Save

- Order number and Picker ID are required
- Orders can have multiple items
  - Picked Qty is required for each item.
    - Picked quantity must be greater or equal to 0.
  - Picked Concerns is optional
    - Picked concerns has string or is null.
  - OrderListId is required
    - OrderlistID is a suppressed value on each order item line


![ERD](./grocerylist_erd.png)
