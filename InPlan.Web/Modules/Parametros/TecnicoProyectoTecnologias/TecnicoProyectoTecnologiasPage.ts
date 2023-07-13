import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TecnicoProyectoTecnologiasGrid } from './TecnicoProyectoTecnologiasGrid';

export default function pageInit() {
    initFullHeightGridPage(new TecnicoProyectoTecnologiasGrid($('#GridDiv')).element);
}