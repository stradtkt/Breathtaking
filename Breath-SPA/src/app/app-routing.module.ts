import { RouterModule, Routes } from '@angular/router';
import * as fromHome from './home';
import * as fromUsers from './users';
import { NgModule } from '@angular/core';

const routes: Routes = [
    {path: '', component: fromHome.HomeViewComponent},
    {path: 'about', component: fromHome.AboutComponent},
    {path: 'contact', component: fromHome.ContactComponent},
    {path: 'login', component: fromUsers.LoginComponent},
    {path: 'register', component: fromUsers.RegisterComponent}
];

@NgModule({
    imports: [
        RouterModule.forRoot(routes)
    ],
    exports: [RouterModule]
})

export class AppRoutingModule {}
