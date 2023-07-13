import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TecnicosProyectosGrid } from './TecnicosProyectosGrid';

export default function pageInit() {
    initFullHeightGridPage(new TecnicosProyectosGrid($('#GridDiv')).element);
}