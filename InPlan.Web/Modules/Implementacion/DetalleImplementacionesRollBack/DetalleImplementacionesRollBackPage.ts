import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { DetalleImplementacionesRollBackGrid } from './DetalleImplementacionesRollBackGrid';

export default function pageInit() {
    initFullHeightGridPage(new DetalleImplementacionesRollBackGrid($('#GridDiv')).element);
}