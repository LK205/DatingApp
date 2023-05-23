import { Component, OnInit } from '@angular/core';
import { Member } from '../_models/member';
import { MembersService } from '../_services/members.service';
import { Pagigation } from '../_models/pagination';

@Component({
  selector: 'app-lists' ,
  templateUrl: './lists.component.html',
  styleUrls: ['./lists.component.css']
})
export class ListsComponent implements OnInit {
  members: Member[] | undefined;
  predicate = 'liked';
  pageNumber = 1;
  pageSize = 10;
  pagination: Pagigation;

  
  constructor (private memberService: MembersService) {}
  
  ngOnInit(): void {
    this.loadLike();
  }


  loadLike(){
    this.memberService.getLikes(this.predicate, this.pageNumber, this.pageSize).subscribe(response =>{
      this.members = response.result;
      this.pagination = response.pagination;
    })
  }

  pageChanged(event: any){
    this.pageNumber = event.page;
    this.loadLike();
  }
}
