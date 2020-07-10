import { Routes } from '@angular/router';
import { AuthGuard } from './_guards/auth.guard';
import * as fromHome from './home/index';


export const appRoutes: Routes = [
    {path: '', component: fromHome.HomeComponent},
    {path: 'about', component: fromHome.AboutComponent},
    {path: 'contact', component: fromHome.ContactComponent},
    {path: '**', redirectTo: '', pathMatch: 'full'}
]
