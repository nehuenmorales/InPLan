import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { EstadosTareasGrid } from './EstadosTareasGrid';

export default function pageInit() {
    initFullHeightGridPage(new EstadosTareasGrid($('#GridDiv')).element);
}