import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { AmbientesProyectosGrid } from './AmbientesProyectosGrid';

export default function pageInit() {
    initFullHeightGridPage(new AmbientesProyectosGrid($('#GridDiv')).element);
}