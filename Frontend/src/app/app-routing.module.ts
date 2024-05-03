import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { JSONtoXMLComponent } from './jsonto-xml/jsonto-xml.component';

const routes: Routes = [
  {path:"",redirectTo:"jsonConvert",pathMatch:"full"},
  {path:"jsonConvert",component:JSONtoXMLComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
