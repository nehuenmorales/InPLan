import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { EmpresasGrid } from './EmpresasGrid';

export default function pageInit() {
    initFullHeightGridPage(new EmpresasGrid($('#GridDiv')).element);
}