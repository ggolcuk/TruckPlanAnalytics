# Truck Plan System Assumptions and Out-of-Scope Items

## Out-of-Scope:

1. **Fully Functional Program:** 
   - The creation of an end-to-end, fully functional program is out of scope for this exercise.
  
2. **Functionalities:** 
   - While interfaces are provided for a broad range of possible functionalities, their complete implementations remain out of scope.

3. **Third-party Service Connections:** 
   - The functions that would connect to third-party services for distance calculations and country determination from coordinates are not implemented. However, interfaces have been provided for these tasks.

4. **Database System:** 
   - This implementation assumes the use of SQL as the database system. But the functional database is out of scope.

5. **Test Cases**
   - Test cases, test coverage is out of scope

6. **Outliers**
   - Fail safes, sanity checks and outlier filters are not considered

## Assumptions:

1. **Truck Plan Creation:** 
   - A truck plan is initiated either by the system or by a user.

2. **Driver and Truck Assignment:** 
   - Every truck plan will have a driver and a truck assigned to it.

3. **GPS Data Collection:** 
   - Once a truck plan is activated, the truck's GPS system will log its position approximately every 5 minutes. This data is then stored under the associated truck plan.

4. **Plan Conclusion:** 
   - When a truck plan concludes (e.g., the truck arrives at its destination), the truck plan is marked as closed.

5. **Distance and Country Calculation:** 
   - Upon the conclusion of a truck plan, third-party services are assumed to be invoked to determine the approximate distance covered by the truck and the countries it traveled through during the journey.