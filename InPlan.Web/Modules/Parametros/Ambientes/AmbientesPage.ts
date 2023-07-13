import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { AmbientesGrid } from './AmbientesGrid';

export default function pageInit() {
    initFullHeightGridPage(new AmbientesGrid($('#GridDiv')).element);
}