import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { EstadosDetalleImplementacionesGrid } from './EstadosDetalleImplementacionesGrid';

export default function pageInit() {
    initFullHeightGridPage(new EstadosDetalleImplementacionesGrid($('#GridDiv')).element);
}