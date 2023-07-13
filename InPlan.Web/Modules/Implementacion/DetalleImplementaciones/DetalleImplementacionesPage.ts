import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { DetalleImplementacionesGrid } from './DetalleImplementacionesGrid';

export default function pageInit() {
    initFullHeightGridPage(new DetalleImplementacionesGrid($('#GridDiv')).element);
}