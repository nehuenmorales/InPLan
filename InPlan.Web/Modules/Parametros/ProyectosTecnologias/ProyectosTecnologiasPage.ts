import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ProyectosTecnologiasGrid } from './ProyectosTecnologiasGrid';

export default function pageInit() {
    initFullHeightGridPage(new ProyectosTecnologiasGrid($('#GridDiv')).element);
}