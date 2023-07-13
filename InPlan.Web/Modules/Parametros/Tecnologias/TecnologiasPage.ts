import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TecnologiasGrid } from './TecnologiasGrid';

export default function pageInit() {
    initFullHeightGridPage(new TecnologiasGrid($('#GridDiv')).element);
}