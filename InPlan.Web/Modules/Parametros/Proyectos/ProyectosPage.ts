import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ProyectosGrid } from './ProyectosGrid';

export default function pageInit() {
    initFullHeightGridPage(new ProyectosGrid($('#GridDiv')).element);
}