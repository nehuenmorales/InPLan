import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { EstadosDetalleImplementacioneRollBackGrid } from './EstadosDetalleImplementacioneRollBackGrid';

export default function pageInit() {
    initFullHeightGridPage(new EstadosDetalleImplementacioneRollBackGrid($('#GridDiv')).element);
}