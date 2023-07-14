import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ClientesGrid } from './ClientesGrid';

export default function pageInit() {
    initFullHeightGridPage(new ClientesGrid($('#GridDiv')).element);
}