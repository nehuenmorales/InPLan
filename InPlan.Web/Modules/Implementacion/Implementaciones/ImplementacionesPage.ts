import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ImplementacionesGrid } from './ImplementacionesGrid';

export default function pageInit() {
    initFullHeightGridPage(new ImplementacionesGrid($('#GridDiv')).element);
}