import { User } from "./user";

export class UserParams{
    gender: string;
    minAge = 16;
    maxAge = 90;
    pageNumber = 1;
    pageSize = 10;
    orderBy = 'lastActive'; 

    constructor(user: User){
        this.gender = user.gender === 'female'? 'male' : 'female';
    }
}