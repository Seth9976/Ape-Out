using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRewired.ControllerExtensions;
using Il2CppRewired.Utils.Classes.Data;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.HID.Drivers
{
	// Token: 0x02000118 RID: 280
	public class DualSenseDriver : HIDDeviceDriver
	{
		// Token: 0x06001AA6 RID: 6822 RVA: 0x00094704 File Offset: 0x00092904
		// Note: this type is marked as 'beforefieldinit'.
		static DualSenseDriver()
		{
			Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.HID.Drivers", "DualSenseDriver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr);
			DualSenseDriver.NativeFieldInfoPtr_cBswOuBTFJaQmJaEsTSUwghjEsxb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "cBswOuBTFJaQmJaEsTSUwghjEsxb");
			DualSenseDriver.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "XQHSiIMpmpLQwAfijbkQiqJbUVm");
			DualSenseDriver.NativeFieldInfoPtr_ZSAekMXsJdpwJeuHzaalTvrqTXZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "ZSAekMXsJdpwJeuHzaalTvrqTXZ");
			DualSenseDriver.NativeFieldInfoPtr_xQFBlnjHmSMxSYBxUcplNCrUIpHy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "xQFBlnjHmSMxSYBxUcplNCrUIpHy");
			DualSenseDriver.NativeFieldInfoPtr_DXQOduZMAdakgKHULREouGGIMsj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "DXQOduZMAdakgKHULREouGGIMsj");
			DualSenseDriver.NativeFieldInfoPtr_jkpagfZjLjeageiKHUvdcGIBUyjQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "jkpagfZjLjeageiKHUvdcGIBUyjQ");
			DualSenseDriver.NativeFieldInfoPtr_CbvTpyUAreHQTqRwrRyHFkkvRu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "CbvTpyUAreHQTqRwrRyHFkkvRu");
			DualSenseDriver.NativeFieldInfoPtr_qkfbSOvdxzFTGQsCjAxNayadEWhk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "qkfbSOvdxzFTGQsCjAxNayadEWhk");
			DualSenseDriver.NativeFieldInfoPtr_sstgLgFYucqXUgQCuJWZzpHiirhL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "sstgLgFYucqXUgQCuJWZzpHiirhL");
			DualSenseDriver.NativeFieldInfoPtr_AHJqxkYPMecTbQnOZRgFvJYDGTg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "AHJqxkYPMecTbQnOZRgFvJYDGTg");
			DualSenseDriver.NativeFieldInfoPtr_ykFUEgafLAgAceDkWcqiMSzQgGhj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "ykFUEgafLAgAceDkWcqiMSzQgGhj");
			DualSenseDriver.NativeFieldInfoPtr_ucCwnEJshdgPokipDfKZUPXVGns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "ucCwnEJshdgPokipDfKZUPXVGns");
			DualSenseDriver.NativeFieldInfoPtr_HQywWIGQbJvUyoAzHWTXqleTChs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "HQywWIGQbJvUyoAzHWTXqleTChs");
			DualSenseDriver.NativeFieldInfoPtr_cHNhpgkLYTObmpHxVWxLGMeDyrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "cHNhpgkLYTObmpHxVWxLGMeDyrl");
			DualSenseDriver.NativeFieldInfoPtr_iZucelPQVvvGHDiPkrqCheppWEb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "iZucelPQVvvGHDiPkrqCheppWEb");
			DualSenseDriver.NativeFieldInfoPtr_uxwENVeAtCyNlYtYwbcddIUTAOou = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "uxwENVeAtCyNlYtYwbcddIUTAOou");
			DualSenseDriver.NativeFieldInfoPtr_LgKeAUHCkufZaobBGjJCDaKYadH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "LgKeAUHCkufZaobBGjJCDaKYadH");
			DualSenseDriver.NativeFieldInfoPtr_jNwxjQilyePbFeoWPyFoqMeoVFo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "jNwxjQilyePbFeoWPyFoqMeoVFo");
			DualSenseDriver.NativeFieldInfoPtr_FXtDWUVkUWyrNZDVfPmoAYzjdSk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "FXtDWUVkUWyrNZDVfPmoAYzjdSk");
			DualSenseDriver.NativeFieldInfoPtr_XSDHwGduufZGdjcfZNgipchoaDh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "XSDHwGduufZGdjcfZNgipchoaDh");
			DualSenseDriver.NativeFieldInfoPtr_KbJfnNWgRWWhYQPqfyOdakWTCzV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "KbJfnNWgRWWhYQPqfyOdakWTCzV");
			DualSenseDriver.NativeFieldInfoPtr_pGMNRoiPiXVgurNedyumDvLSWye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "pGMNRoiPiXVgurNedyumDvLSWye");
			DualSenseDriver.NativeFieldInfoPtr_vnnAZtLgkFVwgtIbWVvtOytbiVQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "vnnAZtLgkFVwgtIbWVvtOytbiVQ");
			DualSenseDriver.NativeFieldInfoPtr_EOghpTMwtDUuRuFBCAqiAhLpvK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "EOghpTMwtDUuRuFBCAqiAhLpvK");
			DualSenseDriver.NativeFieldInfoPtr_qVDotNVsrZIVnBEmMnFuVBdendu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "qVDotNVsrZIVnBEmMnFuVBdendu");
			DualSenseDriver.NativeFieldInfoPtr_hcBaVJxFQfmUjEoteGSzULttyVK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "hcBaVJxFQfmUjEoteGSzULttyVK");
			DualSenseDriver.NativeFieldInfoPtr_CCVbhVJfxwwdDigIhqkdBPtgRraU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "CCVbhVJfxwwdDigIhqkdBPtgRraU");
			DualSenseDriver.NativeFieldInfoPtr_BBxhpfDMNTIyFeBupCZIVerwBWD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "BBxhpfDMNTIyFeBupCZIVerwBWD");
			DualSenseDriver.NativeFieldInfoPtr_DjKakIgesLnAHNafOLmjWaZijsjK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "DjKakIgesLnAHNafOLmjWaZijsjK");
			DualSenseDriver.NativeFieldInfoPtr_foWgjLXVSVMFiWVEEVhFNgtUENi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "foWgjLXVSVMFiWVEEVhFNgtUENi");
			DualSenseDriver.NativeFieldInfoPtr_yNXkfmYzMlAdJuzyPdItIntpuRG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "yNXkfmYzMlAdJuzyPdItIntpuRG");
			DualSenseDriver.NativeFieldInfoPtr_izvXmSrSPbVoCbIocjuxlbdJFKp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "izvXmSrSPbVoCbIocjuxlbdJFKp");
			DualSenseDriver.NativeFieldInfoPtr_geesShSZbWMRDQXWdWhQsuPIYbg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "geesShSZbWMRDQXWdWhQsuPIYbg");
			DualSenseDriver.NativeFieldInfoPtr_EsFJPdDRcznZMMLQtKTzZswcLZN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "EsFJPdDRcznZMMLQtKTzZswcLZN");
			DualSenseDriver.NativeFieldInfoPtr_DfBydhNWOOkPYugrHJaqMYmzYxW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "DfBydhNWOOkPYugrHJaqMYmzYxW");
			DualSenseDriver.NativeFieldInfoPtr_axsAWDoBfYTvKuiIBVCENVMNClI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "axsAWDoBfYTvKuiIBVCENVMNClI");
			DualSenseDriver.NativeFieldInfoPtr_RkmXSIwacUHALbRdEDzDbXwbiNm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "RkmXSIwacUHALbRdEDzDbXwbiNm");
			DualSenseDriver.NativeFieldInfoPtr_zNJxXdOIpKiDcgASoCbBJWVmwUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "zNJxXdOIpKiDcgASoCbBJWVmwUT");
			DualSenseDriver.NativeFieldInfoPtr_RUqxFhXZXCJwBaIXjyWYPbcseaN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "RUqxFhXZXCJwBaIXjyWYPbcseaN");
			DualSenseDriver.NativeFieldInfoPtr_XBkDTaPuOgAzSaajZefNYCwjBVjF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "XBkDTaPuOgAzSaajZefNYCwjBVjF");
			DualSenseDriver.NativeFieldInfoPtr_HCtvxTtdKBvBsmGhirWtPRCQIHe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "HCtvxTtdKBvBsmGhirWtPRCQIHe");
			DualSenseDriver.NativeFieldInfoPtr_YowfJgjPDjgBdWLQsQIkeMUIwCSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "YowfJgjPDjgBdWLQsQIkeMUIwCSG");
			DualSenseDriver.NativeFieldInfoPtr_fBLvQFYipvjtlfYVBgxEMoFHCiiB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "fBLvQFYipvjtlfYVBgxEMoFHCiiB");
			DualSenseDriver.NativeFieldInfoPtr_SMoAnscTohLhkRCINmKDimcdDrha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "SMoAnscTohLhkRCINmKDimcdDrha");
			DualSenseDriver.NativeFieldInfoPtr_ewAwOWPRZrTGiLDAAiOYHtWvayr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "ewAwOWPRZrTGiLDAAiOYHtWvayr");
			DualSenseDriver.NativeFieldInfoPtr_nbksJZgjBqdspiaJiKOmAmEioaiH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "nbksJZgjBqdspiaJiKOmAmEioaiH");
			DualSenseDriver.NativeFieldInfoPtr_DugdatQgfbvfYbWbkKLDKCYLPaA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "DugdatQgfbvfYbWbkKLDKCYLPaA");
			DualSenseDriver.NativeFieldInfoPtr_DAUINcLKpAQacqmWMUIzRBtPWQi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "DAUINcLKpAQacqmWMUIzRBtPWQi");
			DualSenseDriver.NativeFieldInfoPtr_QYRvzOxFNpkSULNPpVRzHPlduSR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "QYRvzOxFNpkSULNPpVRzHPlduSR");
			DualSenseDriver.NativeFieldInfoPtr_ercldrMDMwXEPurVOaoJxnVVpls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "ercldrMDMwXEPurVOaoJxnVVpls");
			DualSenseDriver.NativeFieldInfoPtr_YPjwmLyiGMgZqaXDYTZImQRTYEO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "YPjwmLyiGMgZqaXDYTZImQRTYEO");
			DualSenseDriver.NativeFieldInfoPtr_OPYDCjKKkittUJrThlfyTQNZWEIG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "OPYDCjKKkittUJrThlfyTQNZWEIG");
			DualSenseDriver.NativeFieldInfoPtr_mjBnEAbcHYxisFdFlFoFkBglZOBn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "mjBnEAbcHYxisFdFlFoFkBglZOBn");
			DualSenseDriver.NativeFieldInfoPtr_VFDHHQcZdJhoVuZYXYHsXvpfeOL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "VFDHHQcZdJhoVuZYXYHsXvpfeOL");
			DualSenseDriver.NativeFieldInfoPtr_MXGPRGAXeZnmaeVJRhyPEaVTkXQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "MXGPRGAXeZnmaeVJRhyPEaVTkXQ");
			DualSenseDriver.NativeFieldInfoPtr_TUDBImFUfxFLWRotJFCpRJvzDZa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "TUDBImFUfxFLWRotJFCpRJvzDZa");
			DualSenseDriver.NativeFieldInfoPtr_bkfuctINqlGyShIdchJBqLCYxstJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "bkfuctINqlGyShIdchJBqLCYxstJ");
			DualSenseDriver.NativeFieldInfoPtr_ckzrduSceznhfUkVNVzAlrFMzOk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "ckzrduSceznhfUkVNVzAlrFMzOk");
			DualSenseDriver.NativeFieldInfoPtr_lXKFeRBfejoFIuuyCCeCQPgXmdAP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "lXKFeRBfejoFIuuyCCeCQPgXmdAP");
			DualSenseDriver.NativeFieldInfoPtr_qDdCVvKQZbrijiZvgipubafbXOo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "qDdCVvKQZbrijiZvgipubafbXOo");
			DualSenseDriver.NativeFieldInfoPtr_LcPJePsNJDGRzaAichDdYIgnONuI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "LcPJePsNJDGRzaAichDdYIgnONuI");
			DualSenseDriver.NativeFieldInfoPtr_zMjchRqKunNBMOIYPuLIpiVGqId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "zMjchRqKunNBMOIYPuLIpiVGqId");
			DualSenseDriver.NativeFieldInfoPtr_hbVTfeoNOpiGfjtSvuUJcKveeIPP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "hbVTfeoNOpiGfjtSvuUJcKveeIPP");
			DualSenseDriver.NativeFieldInfoPtr_egeIAYGpUfUEQnQHRNtccoCwhkb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "egeIAYGpUfUEQnQHRNtccoCwhkb");
			DualSenseDriver.NativeFieldInfoPtr_uBCvvZAaNoajgRatNflOHdudRbrB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "uBCvvZAaNoajgRatNflOHdudRbrB");
			DualSenseDriver.NativeFieldInfoPtr_mPARfXQHiXPIiWsEdawLAmEocmM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "mPARfXQHiXPIiWsEdawLAmEocmM");
			DualSenseDriver.NativeFieldInfoPtr_tmIocfPzYqSkyWAsAqKlPqHeQyA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "tmIocfPzYqSkyWAsAqKlPqHeQyA");
			DualSenseDriver.NativeFieldInfoPtr_rWuGSHcFIrSEtLmEWnwNAAMIkTQh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "rWuGSHcFIrSEtLmEWnwNAAMIkTQh");
			DualSenseDriver.NativeFieldInfoPtr_FXCndKilsLeiQIcUSfpHzZDAPmwF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "FXCndKilsLeiQIcUSfpHzZDAPmwF");
			DualSenseDriver.NativeFieldInfoPtr_fxDKuXoXhRfNScEQSkchCEEpvBY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "fxDKuXoXhRfNScEQSkchCEEpvBY");
			DualSenseDriver.NativeFieldInfoPtr_dBoIMedCMyQNHjRaJpngjHJXfMdE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "dBoIMedCMyQNHjRaJpngjHJXfMdE");
			DualSenseDriver.NativeFieldInfoPtr_izYKmDpxFzOrqRbOivvudHllUsE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "izYKmDpxFzOrqRbOivvudHllUsE");
			DualSenseDriver.NativeFieldInfoPtr_GeDQfGevPhhOtATwmXkLyHvWccw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "GeDQfGevPhhOtATwmXkLyHvWccw");
			DualSenseDriver.NativeFieldInfoPtr_VqjireeisHBGAbOmixQcKOQABZY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "VqjireeisHBGAbOmixQcKOQABZY");
			DualSenseDriver.NativeFieldInfoPtr_SEQenGfoIoNZmaGLiQDgmYcHfBRG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "SEQenGfoIoNZmaGLiQDgmYcHfBRG");
			DualSenseDriver.NativeFieldInfoPtr_NXVqXgfUsQHbVRrEpuYEreBlzpN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "NXVqXgfUsQHbVRrEpuYEreBlzpN");
			DualSenseDriver.NativeFieldInfoPtr_dzydtpDkcOlbZPaRhVbfGNBdrDQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "dzydtpDkcOlbZPaRhVbfGNBdrDQ");
			DualSenseDriver.NativeFieldInfoPtr_MqcIIdsSwUqQdRoXaTgVghcDhrW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "MqcIIdsSwUqQdRoXaTgVghcDhrW");
			DualSenseDriver.NativeFieldInfoPtr_WiKTTbpsgABuAkMhYSavFVjifRv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "WiKTTbpsgABuAkMhYSavFVjifRv");
			DualSenseDriver.NativeFieldInfoPtr_GjYzRFszhGQQgQSGrnIRVGWAJXr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "GjYzRFszhGQQgQSGrnIRVGWAJXr");
			DualSenseDriver.NativeFieldInfoPtr_vWODbbChHxjsJwFcccLzWSgbQGAI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "vWODbbChHxjsJwFcccLzWSgbQGAI");
			DualSenseDriver.NativeFieldInfoPtr_XVfeDFKQSiWWjEnCYqeBmfVLANBm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "XVfeDFKQSiWWjEnCYqeBmfVLANBm");
			DualSenseDriver.NativeFieldInfoPtr_UGsfEPbEftfDkZDHEhvZKzvpejCh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "UGsfEPbEftfDkZDHEhvZKzvpejCh");
			DualSenseDriver.NativeFieldInfoPtr_ZMBMGVjsrAkVGgxKxyCxRULydmm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "ZMBMGVjsrAkVGgxKxyCxRULydmm");
			DualSenseDriver.NativeFieldInfoPtr_ONdUFSUycItfOpOkWTvesaAwuVs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "ONdUFSUycItfOpOkWTvesaAwuVs");
			DualSenseDriver.NativeFieldInfoPtr_kEQdqkMxSYRqzzGPHAxtXPlPzkZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "kEQdqkMxSYRqzzGPHAxtXPlPzkZ");
			DualSenseDriver.NativeFieldInfoPtr_WCfDoojgzpSlStzOsMyPeCbQeaJj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "WCfDoojgzpSlStzOsMyPeCbQeaJj");
			DualSenseDriver.NativeFieldInfoPtr_kQKpjVOkPcBOqzzgUcfedubZWIg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "kQKpjVOkPcBOqzzgUcfedubZWIg");
			DualSenseDriver.NativeFieldInfoPtr_lGFnvrVsYXArhmLqurfppgtHXZR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "lGFnvrVsYXArhmLqurfppgtHXZR");
			DualSenseDriver.NativeFieldInfoPtr_FickyNoxMCrkMPcgwygIhassLQk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "FickyNoxMCrkMPcgwygIhassLQk");
			DualSenseDriver.NativeFieldInfoPtr_EscSNlnNIwRgGQmzBHNegrWcYDH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "EscSNlnNIwRgGQmzBHNegrWcYDH");
			DualSenseDriver.NativeFieldInfoPtr_RTKlxLjGuZLRqfVuXrlNDhwBiTy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "RTKlxLjGuZLRqfVuXrlNDhwBiTy");
			DualSenseDriver.NativeFieldInfoPtr_ippVKLLMqIBFhRtXoenvVQntAJd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "ippVKLLMqIBFhRtXoenvVQntAJd");
			DualSenseDriver.NativeFieldInfoPtr_qjntYfLoESbAWHDBNDGxRCXJMfy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "qjntYfLoESbAWHDBNDGxRCXJMfy");
			DualSenseDriver.NativeFieldInfoPtr_XnRnoVdLhJkUOHOAQhipOOfFLpk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "XnRnoVdLhJkUOHOAQhipOOfFLpk");
			DualSenseDriver.NativeFieldInfoPtr_bUbhTMCGWaCoOqSuDMxcebgtRqzV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "bUbhTMCGWaCoOqSuDMxcebgtRqzV");
			DualSenseDriver.NativeFieldInfoPtr_OLKxRVqOsIErBUQFLStrlOJjitj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "OLKxRVqOsIErBUQFLStrlOJjitj");
			DualSenseDriver.NativeFieldInfoPtr_oHPGAxVesPYWMwkICufJHTEytZG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "oHPGAxVesPYWMwkICufJHTEytZG");
			DualSenseDriver.NativeFieldInfoPtr_nQtUtyADXujDLjRfcvigVPkcmUX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "nQtUtyADXujDLjRfcvigVPkcmUX");
			DualSenseDriver.NativeFieldInfoPtr_pmmntafFsJVEOxFZPqxaaiZpAMO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "pmmntafFsJVEOxFZPqxaaiZpAMO");
			DualSenseDriver.NativeFieldInfoPtr_aOwynHDBqdQEJSMuGFrjRNscfyAD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "aOwynHDBqdQEJSMuGFrjRNscfyAD");
			DualSenseDriver.NativeFieldInfoPtr_oTQFLvxokTfPetxLSxzfnaixHvs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "oTQFLvxokTfPetxLSxzfnaixHvs");
			DualSenseDriver.NativeFieldInfoPtr_DhbhSRVhmFGIEaEXjUaEnRbxQZd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "DhbhSRVhmFGIEaEXjUaEnRbxQZd");
			DualSenseDriver.NativeFieldInfoPtr_oYSRduOYkhJTOKlJmpGdAomDMXu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, "oYSRduOYkhJTOKlJmpGdAomDMXu");
			DualSenseDriver.NativeMethodInfoPtr_get_isVibrating_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669541);
			DualSenseDriver.NativeMethodInfoPtr_get_BatteryLevel_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669542);
			DualSenseDriver.NativeMethodInfoPtr_get_BatteryCharging_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669543);
			DualSenseDriver.NativeMethodInfoPtr_get_LeftMotor_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669544);
			DualSenseDriver.NativeMethodInfoPtr_set_LeftMotor_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669545);
			DualSenseDriver.NativeMethodInfoPtr_get_RightMotor_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669546);
			DualSenseDriver.NativeMethodInfoPtr_set_RightMotor_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669547);
			DualSenseDriver.NativeMethodInfoPtr_get_LightColorR_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669548);
			DualSenseDriver.NativeMethodInfoPtr_set_LightColorR_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669549);
			DualSenseDriver.NativeMethodInfoPtr_get_LightColorG_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669550);
			DualSenseDriver.NativeMethodInfoPtr_set_LightColorG_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669551);
			DualSenseDriver.NativeMethodInfoPtr_get_LightColorB_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669552);
			DualSenseDriver.NativeMethodInfoPtr_set_LightColorB_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669553);
			DualSenseDriver.NativeMethodInfoPtr_get_LightFlashOnDuration_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669554);
			DualSenseDriver.NativeMethodInfoPtr_set_LightFlashOnDuration_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669555);
			DualSenseDriver.NativeMethodInfoPtr_get_LightFlashOffDuration_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669556);
			DualSenseDriver.NativeMethodInfoPtr_set_LightFlashOffDuration_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669557);
			DualSenseDriver.NativeMethodInfoPtr_get_microphoneLightMode_Public_Virtual_Final_New_get_DualSenseMicrophoneLightMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669558);
			DualSenseDriver.NativeMethodInfoPtr_set_microphoneLightMode_Public_Virtual_Final_New_set_Void_DualSenseMicrophoneLightMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669559);
			DualSenseDriver.NativeMethodInfoPtr_get_otherLightBrightness_Public_Virtual_Final_New_get_DualSenseOtherLightBrightness_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669560);
			DualSenseDriver.NativeMethodInfoPtr_set_otherLightBrightness_Public_Virtual_Final_New_set_Void_DualSenseOtherLightBrightness_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669561);
			DualSenseDriver.NativeMethodInfoPtr_get_playerLights_Public_Virtual_Final_New_get_DualSensePlayerLightFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669562);
			DualSenseDriver.NativeMethodInfoPtr_set_playerLights_Public_Virtual_Final_New_set_Void_DualSensePlayerLightFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669563);
			DualSenseDriver.NativeMethodInfoPtr_get_AccelerometerValue_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669564);
			DualSenseDriver.NativeMethodInfoPtr_get_AccelerometerValueRaw_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669565);
			DualSenseDriver.NativeMethodInfoPtr_get_GyroscopeValue_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669566);
			DualSenseDriver.NativeMethodInfoPtr_get_GyroscopeValueRaw_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669567);
			DualSenseDriver.NativeMethodInfoPtr_get_LastGyroscopeValue_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669568);
			DualSenseDriver.NativeMethodInfoPtr_get_LastGyroscopeValueRaw_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669569);
			DualSenseDriver.NativeMethodInfoPtr_get_Orientation_Public_Virtual_Final_New_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669570);
			DualSenseDriver.NativeMethodInfoPtr_ResetOrientation_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669571);
			DualSenseDriver.NativeMethodInfoPtr_get_MaxTouches_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669572);
			DualSenseDriver.NativeMethodInfoPtr_GetTouchCount_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669573);
			DualSenseDriver.NativeMethodInfoPtr_IsTouchingAtIndex_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669574);
			DualSenseDriver.NativeMethodInfoPtr_IsTouchingAtTouchId_Public_Virtual_Final_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669575);
			DualSenseDriver.NativeMethodInfoPtr_GetTouchIdAtIndex_Public_Virtual_Final_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669576);
			DualSenseDriver.NativeMethodInfoPtr_GetTouchPositionByIndex_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669577);
			DualSenseDriver.NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669578);
			DualSenseDriver.NativeMethodInfoPtr_GetTouchPositionAbsoluteByIndex_Public_Virtual_Final_New_Boolean_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669579);
			DualSenseDriver.NativeMethodInfoPtr_GetTouchPositionAbsoluteByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669580);
			DualSenseDriver.NativeMethodInfoPtr_StopLightFlash_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669581);
			DualSenseDriver.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669582);
			DualSenseDriver.NativeMethodInfoPtr__ctor_Public_Void_InitArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669583);
			DualSenseDriver.NativeMethodInfoPtr_Update_Public_Virtual_Void_UpdateLoopType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669584);
			DualSenseDriver.NativeMethodInfoPtr_ParseInputReport_Public_Virtual_Boolean_IntPtr_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669585);
			DualSenseDriver.NativeMethodInfoPtr_CreateControllerExtension_Public_Virtual_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669586);
			DualSenseDriver.NativeMethodInfoPtr_TSrVJoovajrfJhhpgPSTUJfwLdn_Private_Void_rBapAxSjeCWOiOHyzennMIRNCHfj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669587);
			DualSenseDriver.NativeMethodInfoPtr_zNXomrMcpdzggtTitEdjWdzqgEbj_Private_Boolean_rBapAxSjeCWOiOHyzennMIRNCHfj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669588);
			DualSenseDriver.NativeMethodInfoPtr_IuZFpZfntxLYutBfTAuqVYKxfjj_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669589);
			DualSenseDriver.NativeMethodInfoPtr_IuZFpZfntxLYutBfTAuqVYKxfjj_Private_Void_NativeBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669590);
			DualSenseDriver.NativeMethodInfoPtr_bWlObuwhPuWKIEdjMaLCkLFuAubl_Private_Boolean_rBapAxSjeCWOiOHyzennMIRNCHfj_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669591);
			DualSenseDriver.NativeMethodInfoPtr_QLZdJmwnUkddZisUnLmixtMACSh_Private_Void_NativeBuffer_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669592);
			DualSenseDriver.NativeMethodInfoPtr_gbHdOZilzwmhPaLsoSTdCfNBZKKu_Private_Void_Il2CppReferenceArray_1_HIDControllerElement_NativeBuffer_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669593);
			DualSenseDriver.NativeMethodInfoPtr_KHqFCPtEwwtfLgFTiAQgQrcOjjb_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669594);
			DualSenseDriver.NativeMethodInfoPtr_LeplGUzBFQKWBFpGxiDontkepOK_Private_Void_NativeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669595);
			DualSenseDriver.NativeMethodInfoPtr_TLwGAPVnufqvIFbiUtPrqoyNGkr_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669596);
			DualSenseDriver.NativeMethodInfoPtr_cohbXzjxzOcNAeSeyhxjbfXCJFQ_Private_Static_Boolean_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669597);
			DualSenseDriver.NativeMethodInfoPtr_OeYAIeGFRPZFIOSRbUgsokmVUlq_Private_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669598);
			DualSenseDriver.NativeMethodInfoPtr_vZfQKBwCEWApahARXbtasPYbHzZ_Private_Static_Quaternion_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669599);
			DualSenseDriver.NativeMethodInfoPtr_HNzAAnmQWRfPwDoAHmOVRTmQhjHg_Private_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669600);
			DualSenseDriver.NativeMethodInfoPtr_thTaDDdinQFebglkGeuCSsdQcuKj_Private_Quaternion_Quaternion_pDwfbxnaRgNWVWTVBoPzQJoWExW_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669601);
			DualSenseDriver.NativeMethodInfoPtr_Inverse_Public_Static_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669602);
			DualSenseDriver.NativeMethodInfoPtr_TLAawbbzgTTOntVMVRSOYGgBlSz_Private_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669603);
			DualSenseDriver.NativeMethodInfoPtr_TgJSJBfkacluENeCrcEMrjyCzZk_Private_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669604);
			DualSenseDriver.NativeMethodInfoPtr_EVPzweUACCpCpHpeeEMnGnyiGub_Private_Quaternion_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669605);
			DualSenseDriver.NativeMethodInfoPtr_FTcGFQGKepOCGivEwiXcIfpiwzo_Private_Quaternion_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669606);
			DualSenseDriver.NativeMethodInfoPtr_fQsbUcErhAOleloWxhSUBrwCiPqT_Private_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669607);
			DualSenseDriver.NativeMethodInfoPtr_ekTnVhTROxwNIqHvokaYcuOYwut_Private_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669608);
			DualSenseDriver.NativeMethodInfoPtr_robusEWPfTfHCeHSBdccMSzDezZ_Private_Boolean_Vector3_byref_hcFgwcIDMlBhmOMlfSjUYrwdSdO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669609);
			DualSenseDriver.NativeMethodInfoPtr_DIkDxlDsItuOVMlNgZuHlQvMhaFQ_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669610);
			DualSenseDriver.NativeMethodInfoPtr_uaWAYcACiSsMWDcNpMnjBRRdSgR_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669611);
			DualSenseDriver.NativeMethodInfoPtr_DtptwGvMHHWYtiObmjGUBSGKWWS_Private_Vector3_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669612);
			DualSenseDriver.NativeMethodInfoPtr_ThbIRbwHDVgOvNnDNaPNIFyStTC_Private_Vector3_ExpandableArray_DataContainer_1_vwnDNljqUPuTIauvXLOcbBHPCtP_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669613);
			DualSenseDriver.NativeMethodInfoPtr_ThbIRbwHDVgOvNnDNaPNIFyStTC_Private_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669614);
			DualSenseDriver.NativeMethodInfoPtr_jouvWBjeMlbfGjdhJNLFnQsLdBOb_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669615);
			DualSenseDriver.NativeMethodInfoPtr_prYGimAxzhhkgHXVHtncfHnGFYY_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669616);
			DualSenseDriver.NativeMethodInfoPtr_qeFMJjnMLTATARRnrcCxoPuiWfW_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669617);
			DualSenseDriver.NativeMethodInfoPtr_nQkXLniZUrHBOFIEofKzaOcIykH_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669618);
			DualSenseDriver.NativeMethodInfoPtr_sDEBJHxzkRveoJulMncayCApMQt_Private_Void_NativeBuffer_Il2CppStructArray_1_TouchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669619);
			DualSenseDriver.NativeMethodInfoPtr_okliethpUEesGZsNxgsPNrXkCiZ_Private_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669620);
			DualSenseDriver.NativeMethodInfoPtr_dGrqytUXXWkxJliqQJXVhZPBxBd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669621);
			DualSenseDriver.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669622);
			DualSenseDriver.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669623);
			DualSenseDriver.NativeMethodInfoPtr_Matches_Public_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669624);
			DualSenseDriver.NativeMethodInfoPtr_QPTYfSspdaYTKmpyYDTIDnYwATk_Private_Static_UInt32_NativeBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669625);
			DualSenseDriver.NativeMethodInfoPtr_tTNzTwfCMQfwvWqHsIiWcwmruoU_Private_Static_uASSUXqpRKvdvBmSBaslDYQnViNe_DualSenseOtherLightBrightness_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669626);
			DualSenseDriver.NativeMethodInfoPtr_ycNGLfgdPFBcicRXNFIZGfRisvEb_Private_Static_DualSenseOtherLightBrightness_uASSUXqpRKvdvBmSBaslDYQnViNe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr, 100669627);
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06001AA7 RID: 6823 RVA: 0x00095620 File Offset: 0x00093820
		public unsafe bool isVibrating
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279238, XrefRangeEnd = 279240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_get_isVibrating_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06001AA8 RID: 6824 RVA: 0x0009565C File Offset: 0x0009385C
		public unsafe virtual float BatteryLevel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279240, XrefRangeEnd = 279241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_get_BatteryLevel_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06001AA9 RID: 6825 RVA: 0x00095698 File Offset: 0x00093898
		public unsafe virtual bool BatteryCharging
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_get_BatteryCharging_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06001AAA RID: 6826 RVA: 0x000956D4 File Offset: 0x000938D4
		// (set) Token: 0x06001AAB RID: 6827 RVA: 0x00095710 File Offset: 0x00093910
		public unsafe virtual float LeftMotor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_get_LeftMotor_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279241, XrefRangeEnd = 279242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_set_LeftMotor_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06001AAC RID: 6828 RVA: 0x00095750 File Offset: 0x00093950
		// (set) Token: 0x06001AAD RID: 6829 RVA: 0x0009578C File Offset: 0x0009398C
		public unsafe virtual float RightMotor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_get_RightMotor_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279242, XrefRangeEnd = 279243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_set_RightMotor_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06001AAE RID: 6830 RVA: 0x000957CC File Offset: 0x000939CC
		// (set) Token: 0x06001AAF RID: 6831 RVA: 0x00095808 File Offset: 0x00093A08
		public unsafe virtual float LightColorR
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_get_LightColorR_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279243, XrefRangeEnd = 279245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_set_LightColorR_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x00095848 File Offset: 0x00093A48
		// (set) Token: 0x06001AB1 RID: 6833 RVA: 0x00095884 File Offset: 0x00093A84
		public unsafe virtual float LightColorG
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_get_LightColorG_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279245, XrefRangeEnd = 279247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_set_LightColorG_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x000958C4 File Offset: 0x00093AC4
		// (set) Token: 0x06001AB3 RID: 6835 RVA: 0x00095900 File Offset: 0x00093B00
		public unsafe virtual float LightColorB
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_get_LightColorB_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279247, XrefRangeEnd = 279249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_set_LightColorB_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x00095940 File Offset: 0x00093B40
		// (set) Token: 0x06001AB5 RID: 6837 RVA: 0x0009597C File Offset: 0x00093B7C
		public unsafe virtual float LightFlashOnDuration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_get_LightFlashOnDuration_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279249, XrefRangeEnd = 279250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_set_LightFlashOnDuration_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x000959BC File Offset: 0x00093BBC
		// (set) Token: 0x06001AB7 RID: 6839 RVA: 0x000959F8 File Offset: 0x00093BF8
		public unsafe virtual float LightFlashOffDuration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_get_LightFlashOffDuration_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279250, XrefRangeEnd = 279252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_set_LightFlashOffDuration_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x00095A38 File Offset: 0x00093C38
		// (set) Token: 0x06001AB9 RID: 6841 RVA: 0x00095A74 File Offset: 0x00093C74
		public unsafe virtual DualSenseMicrophoneLightMode microphoneLightMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_get_microphoneLightMode_Public_Virtual_Final_New_get_DualSenseMicrophoneLightMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_set_microphoneLightMode_Public_Virtual_Final_New_set_Void_DualSenseMicrophoneLightMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06001ABA RID: 6842 RVA: 0x00095AB4 File Offset: 0x00093CB4
		// (set) Token: 0x06001ABB RID: 6843 RVA: 0x00095AF0 File Offset: 0x00093CF0
		public unsafe virtual DualSenseOtherLightBrightness otherLightBrightness
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279252, XrefRangeEnd = 279255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_get_otherLightBrightness_Public_Virtual_Final_New_get_DualSenseOtherLightBrightness_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279255, XrefRangeEnd = 279260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_set_otherLightBrightness_Public_Virtual_Final_New_set_Void_DualSenseOtherLightBrightness_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06001ABC RID: 6844 RVA: 0x00095B30 File Offset: 0x00093D30
		// (set) Token: 0x06001ABD RID: 6845 RVA: 0x00095B6C File Offset: 0x00093D6C
		public unsafe virtual DualSensePlayerLightFlags playerLights
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_get_playerLights_Public_Virtual_Final_New_get_DualSensePlayerLightFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_set_playerLights_Public_Virtual_Final_New_set_Void_DualSensePlayerLightFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06001ABE RID: 6846 RVA: 0x00095BAC File Offset: 0x00093DAC
		public unsafe virtual Vector3 AccelerometerValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_get_AccelerometerValue_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06001ABF RID: 6847 RVA: 0x00095BE8 File Offset: 0x00093DE8
		public unsafe virtual Vector3 AccelerometerValueRaw
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_get_AccelerometerValueRaw_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06001AC0 RID: 6848 RVA: 0x00095C24 File Offset: 0x00093E24
		public unsafe virtual Vector3 GyroscopeValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279260, XrefRangeEnd = 279263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_get_GyroscopeValue_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06001AC1 RID: 6849 RVA: 0x00095C60 File Offset: 0x00093E60
		public unsafe virtual Vector3 GyroscopeValueRaw
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279263, XrefRangeEnd = 279266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_get_GyroscopeValueRaw_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x00095C9C File Offset: 0x00093E9C
		public unsafe virtual Vector3 LastGyroscopeValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_get_LastGyroscopeValue_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x00095CD8 File Offset: 0x00093ED8
		public unsafe virtual Vector3 LastGyroscopeValueRaw
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_get_LastGyroscopeValueRaw_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06001AC4 RID: 6852 RVA: 0x00095D14 File Offset: 0x00093F14
		public unsafe virtual Quaternion Orientation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_get_Orientation_Public_Virtual_Final_New_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x00095D50 File Offset: 0x00093F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279266, XrefRangeEnd = 279268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResetOrientation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_ResetOrientation_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06001AC6 RID: 6854 RVA: 0x00095D84 File Offset: 0x00093F84
		public unsafe virtual int MaxTouches
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_get_MaxTouches_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x00095DC0 File Offset: 0x00093FC0
		[CallerCount(0)]
		public unsafe virtual int GetTouchCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_GetTouchCount_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x00095DFC File Offset: 0x00093FFC
		[CallerCount(0)]
		public unsafe virtual bool IsTouchingAtIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_IsTouchingAtIndex_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x00095E48 File Offset: 0x00094048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279268, XrefRangeEnd = 279269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsTouchingAtTouchId(int touchId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touchId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_IsTouchingAtTouchId_Public_Virtual_Final_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x00095E94 File Offset: 0x00094094
		[CallerCount(0)]
		public unsafe virtual int GetTouchIdAtIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_GetTouchIdAtIndex_Public_Virtual_Final_New_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x00095EE0 File Offset: 0x000940E0
		[CallerCount(0)]
		public unsafe virtual bool GetTouchPositionByIndex(int index, out Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_GetTouchPositionByIndex_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x00095F38 File Offset: 0x00094138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279269, XrefRangeEnd = 279271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetTouchPositionByTouchId(int touchId, out Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touchId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x00095F90 File Offset: 0x00094190
		[CallerCount(0)]
		public unsafe virtual bool GetTouchPositionAbsoluteByIndex(int index, out int positionX, out int positionY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &positionX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &positionY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_GetTouchPositionAbsoluteByIndex_Public_Virtual_Final_New_Boolean_Int32_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x00095FF8 File Offset: 0x000941F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279271, XrefRangeEnd = 279273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetTouchPositionAbsoluteByTouchId(int touchId, out int positionX, out int positionY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touchId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &positionX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &positionY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_GetTouchPositionAbsoluteByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x00096060 File Offset: 0x00094260
		[CallerCount(0)]
		public unsafe virtual void StopLightFlash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_StopLightFlash_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x00096094 File Offset: 0x00094294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279273, XrefRangeEnd = 279274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StopVibration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x000960C8 File Offset: 0x000942C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279274, XrefRangeEnd = 279497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DualSenseDriver(HIDDeviceDriver.InitArgs initArgs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DualSenseDriver>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initArgs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr__ctor_Public_Void_InitArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x00096114 File Offset: 0x00094314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279497, XrefRangeEnd = 279506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update(UpdateLoopType updateLoop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateLoop;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DualSenseDriver.NativeMethodInfoPtr_Update_Public_Virtual_Void_UpdateLoopType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x00096160 File Offset: 0x00094360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279506, XrefRangeEnd = 279525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, double timestamp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputReportPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputReportLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timestamp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DualSenseDriver.NativeMethodInfoPtr_ParseInputReport_Public_Virtual_Boolean_IntPtr_Int32_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x000961D0 File Offset: 0x000943D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279525, XrefRangeEnd = 279529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Controller.Extension CreateControllerExtension()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DualSenseDriver.NativeMethodInfoPtr_CreateControllerExtension_Public_Virtual_Extension_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Controller.Extension>(intPtr3) : null;
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x0009621C File Offset: 0x0009441C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279532, RefRangeEnd = 279533, XrefRangeStart = 279529, XrefRangeEnd = 279532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TSrVJoovajrfJhhpgPSTUJfwLdn(rBapAxSjeCWOiOHyzennMIRNCHfj A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_TSrVJoovajrfJhhpgPSTUJfwLdn_Private_Void_rBapAxSjeCWOiOHyzennMIRNCHfj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x0009625C File Offset: 0x0009445C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279536, RefRangeEnd = 279537, XrefRangeStart = 279533, XrefRangeEnd = 279536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool zNXomrMcpdzggtTitEdjWdzqgEbj(rBapAxSjeCWOiOHyzennMIRNCHfj A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_zNXomrMcpdzggtTitEdjWdzqgEbj_Private_Boolean_rBapAxSjeCWOiOHyzennMIRNCHfj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x000962A8 File Offset: 0x000944A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 279555, RefRangeEnd = 279559, XrefRangeStart = 279537, XrefRangeEnd = 279555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IuZFpZfntxLYutBfTAuqVYKxfjj()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_IuZFpZfntxLYutBfTAuqVYKxfjj_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x000962DC File Offset: 0x000944DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279586, RefRangeEnd = 279587, XrefRangeStart = 279559, XrefRangeEnd = 279586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IuZFpZfntxLYutBfTAuqVYKxfjj(NativeBuffer A_1, int A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_IuZFpZfntxLYutBfTAuqVYKxfjj_Private_Void_NativeBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x0009632C File Offset: 0x0009452C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 279595, RefRangeEnd = 279603, XrefRangeStart = 279587, XrefRangeEnd = 279595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool bWlObuwhPuWKIEdjMaLCkLFuAubl(rBapAxSjeCWOiOHyzennMIRNCHfj A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_bWlObuwhPuWKIEdjMaLCkLFuAubl_Private_Boolean_rBapAxSjeCWOiOHyzennMIRNCHfj_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x00096378 File Offset: 0x00094578
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279606, RefRangeEnd = 279607, XrefRangeStart = 279603, XrefRangeEnd = 279606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QLZdJmwnUkddZisUnLmixtMACSh(NativeBuffer A_1, double A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_QLZdJmwnUkddZisUnLmixtMACSh_Private_Void_NativeBuffer_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x000963C8 File Offset: 0x000945C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279607, XrefRangeEnd = 279608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void gbHdOZilzwmhPaLsoSTdCfNBZKKu(Il2CppReferenceArray<HIDControllerElement> A_1, NativeBuffer A_2, double A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_gbHdOZilzwmhPaLsoSTdCfNBZKKu_Private_Void_Il2CppReferenceArray_1_HIDControllerElement_NativeBuffer_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x0009642C File Offset: 0x0009462C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279608, XrefRangeEnd = 279614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void KHqFCPtEwwtfLgFTiAQgQrcOjjb()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_KHqFCPtEwwtfLgFTiAQgQrcOjjb_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x00096460 File Offset: 0x00094660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279614, XrefRangeEnd = 279619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LeplGUzBFQKWBFpGxiDontkepOK(NativeBuffer A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_LeplGUzBFQKWBFpGxiDontkepOK_Private_Void_NativeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x000964A4 File Offset: 0x000946A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279624, RefRangeEnd = 279625, XrefRangeStart = 279619, XrefRangeEnd = 279624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TLwGAPVnufqvIFbiUtPrqoyNGkr()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_TLwGAPVnufqvIFbiUtPrqoyNGkr_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x000964D8 File Offset: 0x000946D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279625, XrefRangeEnd = 279626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool cohbXzjxzOcNAeSeyhxjbfXCJFQ(ref Vector3 A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_cohbXzjxzOcNAeSeyhxjbfXCJFQ_Private_Static_Boolean_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x00096518 File Offset: 0x00094718
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279667, RefRangeEnd = 279668, XrefRangeStart = 279626, XrefRangeEnd = 279667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OeYAIeGFRPZFIOSRbUgsokmVUlq(Vector3 A_1, Vector3 A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_OeYAIeGFRPZFIOSRbUgsokmVUlq_Private_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x00096564 File Offset: 0x00094764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279668, XrefRangeEnd = 279674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion vZfQKBwCEWApahARXbtasPYbHzZ(Quaternion A_0, Vector3 A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_vZfQKBwCEWApahARXbtasPYbHzZ_Private_Static_Quaternion_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x000965B0 File Offset: 0x000947B0
		[CallerCount(0)]
		public unsafe static Vector3 HNzAAnmQWRfPwDoAHmOVRTmQhjHg(Vector3 A_0, Vector3 A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_HNzAAnmQWRfPwDoAHmOVRTmQhjHg_Private_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x000965FC File Offset: 0x000947FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279674, XrefRangeEnd = 279683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quaternion thTaDDdinQFebglkGeuCSsdQcuKj(Quaternion A_1, DualSenseDriver.pDwfbxnaRgNWVWTVBoPzQJoWExW A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_thTaDDdinQFebglkGeuCSsdQcuKj_Private_Quaternion_Quaternion_pDwfbxnaRgNWVWTVBoPzQJoWExW_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x00096654 File Offset: 0x00094854
		[CallerCount(0)]
		public unsafe static Quaternion Inverse(Quaternion quaternion)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref quaternion;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_Inverse_Public_Static_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x00096694 File Offset: 0x00094894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279683, XrefRangeEnd = 279685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float TLAawbbzgTTOntVMVRSOYGgBlSz(float A_1, float A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_TLAawbbzgTTOntVMVRSOYGgBlSz_Private_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x000966EC File Offset: 0x000948EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279685, XrefRangeEnd = 279690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TgJSJBfkacluENeCrcEMrjyCzZk(Vector3 A_1, float A_2 = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_TgJSJBfkacluENeCrcEMrjyCzZk_Private_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x00096744 File Offset: 0x00094944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279690, XrefRangeEnd = 279697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quaternion EVPzweUACCpCpHpeeEMnGnyiGub(Vector3 A_1, float A_2 = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_EVPzweUACCpCpHpeeEMnGnyiGub_Private_Quaternion_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x0009679C File Offset: 0x0009499C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279710, RefRangeEnd = 279712, XrefRangeStart = 279697, XrefRangeEnd = 279710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quaternion FTcGFQGKepOCGivEwiXcIfpiwzo(Vector3 A_1, float A_2 = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_FTcGFQGKepOCGivEwiXcIfpiwzo_Private_Quaternion_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x000967F4 File Offset: 0x000949F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279712, XrefRangeEnd = 279713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float fQsbUcErhAOleloWxhSUBrwCiPqT(Vector3 A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_fQsbUcErhAOleloWxhSUBrwCiPqT_Private_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x00096840 File Offset: 0x00094A40
		[CallerCount(0)]
		public unsafe bool ekTnVhTROxwNIqHvokaYcuOYwut(float A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_ekTnVhTROxwNIqHvokaYcuOYwut_Private_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x0009688C File Offset: 0x00094A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279713, XrefRangeEnd = 279719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool robusEWPfTfHCeHSBdccMSzDezZ(Vector3 A_1, out DualSenseDriver.hcFgwcIDMlBhmOMlfSjUYrwdSdO A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_robusEWPfTfHCeHSBdccMSzDezZ_Private_Boolean_Vector3_byref_hcFgwcIDMlBhmOMlfSjUYrwdSdO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x000968E4 File Offset: 0x00094AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279719, XrefRangeEnd = 279722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DIkDxlDsItuOVMlNgZuHlQvMhaFQ(Vector3 A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_DIkDxlDsItuOVMlNgZuHlQvMhaFQ_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x00096930 File Offset: 0x00094B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279722, XrefRangeEnd = 279723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool uaWAYcACiSsMWDcNpMnjBRRdSgR(Vector3 A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_uaWAYcACiSsMWDcNpMnjBRRdSgR_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x0009697C File Offset: 0x00094B7C
		[CallerCount(0)]
		public unsafe Vector3 DtptwGvMHHWYtiObmjGUBSGKWWS(Il2CppStructArray<float> A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_DtptwGvMHHWYtiObmjGUBSGKWWS_Private_Vector3_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x000969CC File Offset: 0x00094BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279723, XrefRangeEnd = 279725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ThbIRbwHDVgOvNnDNaPNIFyStTC(ExpandableArray_DataContainer<HIDGyroscope.vwnDNljqUPuTIauvXLOcbBHPCtP> A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_ThbIRbwHDVgOvNnDNaPNIFyStTC_Private_Vector3_ExpandableArray_DataContainer_1_vwnDNljqUPuTIauvXLOcbBHPCtP_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x00096A1C File Offset: 0x00094C1C
		[CallerCount(0)]
		public unsafe Vector3 ThbIRbwHDVgOvNnDNaPNIFyStTC(Vector3 A_1, float A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_ThbIRbwHDVgOvNnDNaPNIFyStTC_Private_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x00096A74 File Offset: 0x00094C74
		[CallerCount(0)]
		public unsafe int jouvWBjeMlbfGjdhJNLFnQsLdBOb(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_jouvWBjeMlbfGjdhJNLFnQsLdBOb_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x00096AC0 File Offset: 0x00094CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279725, XrefRangeEnd = 279731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void prYGimAxzhhkgHXVHtncfHnGFYY(Il2CppStructArray<byte> A_1, Il2CppStructArray<float> A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_prYGimAxzhhkgHXVHtncfHnGFYY_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x00096B14 File Offset: 0x00094D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279731, XrefRangeEnd = 279737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void qeFMJjnMLTATARRnrcCxoPuiWfW(Il2CppStructArray<byte> A_1, Il2CppStructArray<float> A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_qeFMJjnMLTATARRnrcCxoPuiWfW_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x00096B68 File Offset: 0x00094D68
		[CallerCount(0)]
		public unsafe float nQkXLniZUrHBOFIEofKzaOcIykH()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_nQkXLniZUrHBOFIEofKzaOcIykH_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x00096BA4 File Offset: 0x00094DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279737, XrefRangeEnd = 279749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void sDEBJHxzkRveoJulMncayCApMQt(NativeBuffer A_1, Il2CppStructArray<HIDTouchpad.TouchData> A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_sDEBJHxzkRveoJulMncayCApMQt_Private_Void_NativeBuffer_Il2CppStructArray_1_TouchData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x00096BF8 File Offset: 0x00094DF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279749, RefRangeEnd = 279751, XrefRangeStart = 279749, XrefRangeEnd = 279749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int okliethpUEesGZsNxgsPNrXkCiZ(int A_1, bool A_2, int A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_okliethpUEesGZsNxgsPNrXkCiZ_Private_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x00096C60 File Offset: 0x00094E60
		[CallerCount(0)]
		public unsafe void dGrqytUXXWkxJliqQJXVhZPBxBd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_dGrqytUXXWkxJliqQJXVhZPBxBd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x00096C94 File Offset: 0x00094E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279751, XrefRangeEnd = 279754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DualSenseDriver.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x00096CD0 File Offset: 0x00094ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279754, XrefRangeEnd = 279758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DualSenseDriver.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x00096D1C File Offset: 0x00094F1C
		[CallerCount(0)]
		public unsafe static bool Matches(int vid, int pid)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_Matches_Public_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x00096D68 File Offset: 0x00094F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279758, XrefRangeEnd = 279763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint QPTYfSspdaYTKmpyYDTIDnYwATk(NativeBuffer A_0, int A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_QPTYfSspdaYTKmpyYDTIDnYwATk_Private_Static_UInt32_NativeBuffer_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00096DB8 File Offset: 0x00094FB8
		[CallerCount(0)]
		public unsafe static DualSenseDriver.uASSUXqpRKvdvBmSBaslDYQnViNe tTNzTwfCMQfwvWqHsIiWcwmruoU(DualSenseOtherLightBrightness A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_tTNzTwfCMQfwvWqHsIiWcwmruoU_Private_Static_uASSUXqpRKvdvBmSBaslDYQnViNe_DualSenseOtherLightBrightness_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x00096DF8 File Offset: 0x00094FF8
		[CallerCount(0)]
		public unsafe static DualSenseOtherLightBrightness ycNGLfgdPFBcicRXNFIZGfRisvEb(DualSenseDriver.uASSUXqpRKvdvBmSBaslDYQnViNe A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DualSenseDriver.NativeMethodInfoPtr_ycNGLfgdPFBcicRXNFIZGfRisvEb_Private_Static_DualSenseOtherLightBrightness_uASSUXqpRKvdvBmSBaslDYQnViNe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x0000AF3A File Offset: 0x0000913A
		public DualSenseDriver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x00096E38 File Offset: 0x00095038
		// (set) Token: 0x06001B00 RID: 6912 RVA: 0x0000AF43 File Offset: 0x00009143
		public unsafe static float cBswOuBTFJaQmJaEsTSUwghjEsxb
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_cBswOuBTFJaQmJaEsTSUwghjEsxb, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_cBswOuBTFJaQmJaEsTSUwghjEsxb, (void*)(&value));
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06001B01 RID: 6913 RVA: 0x00096E54 File Offset: 0x00095054
		// (set) Token: 0x06001B02 RID: 6914 RVA: 0x0000AF51 File Offset: 0x00009151
		public unsafe static int XQHSiIMpmpLQwAfijbkQiqJbUVm
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm, (void*)(&value));
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06001B03 RID: 6915 RVA: 0x00096E70 File Offset: 0x00095070
		// (set) Token: 0x06001B04 RID: 6916 RVA: 0x0000AF5F File Offset: 0x0000915F
		public unsafe static int ZSAekMXsJdpwJeuHzaalTvrqTXZ
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_ZSAekMXsJdpwJeuHzaalTvrqTXZ, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_ZSAekMXsJdpwJeuHzaalTvrqTXZ, (void*)(&value));
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06001B05 RID: 6917 RVA: 0x00096E8C File Offset: 0x0009508C
		// (set) Token: 0x06001B06 RID: 6918 RVA: 0x0000AF6D File Offset: 0x0000916D
		public unsafe static int xQFBlnjHmSMxSYBxUcplNCrUIpHy
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_xQFBlnjHmSMxSYBxUcplNCrUIpHy, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_xQFBlnjHmSMxSYBxUcplNCrUIpHy, (void*)(&value));
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06001B07 RID: 6919 RVA: 0x00096EA8 File Offset: 0x000950A8
		// (set) Token: 0x06001B08 RID: 6920 RVA: 0x0000AF7B File Offset: 0x0000917B
		public unsafe static int DXQOduZMAdakgKHULREouGGIMsj
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_DXQOduZMAdakgKHULREouGGIMsj, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_DXQOduZMAdakgKHULREouGGIMsj, (void*)(&value));
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x00096EC4 File Offset: 0x000950C4
		// (set) Token: 0x06001B0A RID: 6922 RVA: 0x0000AF89 File Offset: 0x00009189
		public unsafe static int jkpagfZjLjeageiKHUvdcGIBUyjQ
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_jkpagfZjLjeageiKHUvdcGIBUyjQ, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_jkpagfZjLjeageiKHUvdcGIBUyjQ, (void*)(&value));
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06001B0B RID: 6923 RVA: 0x00096EE0 File Offset: 0x000950E0
		// (set) Token: 0x06001B0C RID: 6924 RVA: 0x0000AF97 File Offset: 0x00009197
		public unsafe static int CbvTpyUAreHQTqRwrRyHFkkvRu
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_CbvTpyUAreHQTqRwrRyHFkkvRu, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_CbvTpyUAreHQTqRwrRyHFkkvRu, (void*)(&value));
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06001B0D RID: 6925 RVA: 0x00096EFC File Offset: 0x000950FC
		// (set) Token: 0x06001B0E RID: 6926 RVA: 0x0000AFA5 File Offset: 0x000091A5
		public unsafe static bool qkfbSOvdxzFTGQsCjAxNayadEWhk
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_qkfbSOvdxzFTGQsCjAxNayadEWhk, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_qkfbSOvdxzFTGQsCjAxNayadEWhk, (void*)(&value));
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001B0F RID: 6927 RVA: 0x00096F18 File Offset: 0x00095118
		// (set) Token: 0x06001B10 RID: 6928 RVA: 0x0000AFB3 File Offset: 0x000091B3
		public unsafe static bool sstgLgFYucqXUgQCuJWZzpHiirhL
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_sstgLgFYucqXUgQCuJWZzpHiirhL, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_sstgLgFYucqXUgQCuJWZzpHiirhL, (void*)(&value));
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001B11 RID: 6929 RVA: 0x00096F34 File Offset: 0x00095134
		// (set) Token: 0x06001B12 RID: 6930 RVA: 0x0000AFC1 File Offset: 0x000091C1
		public unsafe static float AHJqxkYPMecTbQnOZRgFvJYDGTg
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_AHJqxkYPMecTbQnOZRgFvJYDGTg, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_AHJqxkYPMecTbQnOZRgFvJYDGTg, (void*)(&value));
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001B13 RID: 6931 RVA: 0x00096F50 File Offset: 0x00095150
		// (set) Token: 0x06001B14 RID: 6932 RVA: 0x0000AFCF File Offset: 0x000091CF
		public unsafe static int ykFUEgafLAgAceDkWcqiMSzQgGhj
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_ykFUEgafLAgAceDkWcqiMSzQgGhj, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_ykFUEgafLAgAceDkWcqiMSzQgGhj, (void*)(&value));
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06001B15 RID: 6933 RVA: 0x00096F6C File Offset: 0x0009516C
		// (set) Token: 0x06001B16 RID: 6934 RVA: 0x0000AFDD File Offset: 0x000091DD
		public unsafe static int ucCwnEJshdgPokipDfKZUPXVGns
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_ucCwnEJshdgPokipDfKZUPXVGns, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_ucCwnEJshdgPokipDfKZUPXVGns, (void*)(&value));
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06001B17 RID: 6935 RVA: 0x00096F88 File Offset: 0x00095188
		// (set) Token: 0x06001B18 RID: 6936 RVA: 0x0000AFEB File Offset: 0x000091EB
		public unsafe static int HQywWIGQbJvUyoAzHWTXqleTChs
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_HQywWIGQbJvUyoAzHWTXqleTChs, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_HQywWIGQbJvUyoAzHWTXqleTChs, (void*)(&value));
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06001B19 RID: 6937 RVA: 0x00096FA4 File Offset: 0x000951A4
		// (set) Token: 0x06001B1A RID: 6938 RVA: 0x0000AFF9 File Offset: 0x000091F9
		public unsafe static int cHNhpgkLYTObmpHxVWxLGMeDyrl
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_cHNhpgkLYTObmpHxVWxLGMeDyrl, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_cHNhpgkLYTObmpHxVWxLGMeDyrl, (void*)(&value));
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06001B1B RID: 6939 RVA: 0x00096FC0 File Offset: 0x000951C0
		// (set) Token: 0x06001B1C RID: 6940 RVA: 0x0000B007 File Offset: 0x00009207
		public unsafe static int iZucelPQVvvGHDiPkrqCheppWEb
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_iZucelPQVvvGHDiPkrqCheppWEb, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_iZucelPQVvvGHDiPkrqCheppWEb, (void*)(&value));
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06001B1D RID: 6941 RVA: 0x00096FDC File Offset: 0x000951DC
		// (set) Token: 0x06001B1E RID: 6942 RVA: 0x0000B015 File Offset: 0x00009215
		public unsafe static int uxwENVeAtCyNlYtYwbcddIUTAOou
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_uxwENVeAtCyNlYtYwbcddIUTAOou, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_uxwENVeAtCyNlYtYwbcddIUTAOou, (void*)(&value));
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06001B1F RID: 6943 RVA: 0x00096FF8 File Offset: 0x000951F8
		// (set) Token: 0x06001B20 RID: 6944 RVA: 0x0000B023 File Offset: 0x00009223
		public unsafe static int LgKeAUHCkufZaobBGjJCDaKYadH
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_LgKeAUHCkufZaobBGjJCDaKYadH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_LgKeAUHCkufZaobBGjJCDaKYadH, (void*)(&value));
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06001B21 RID: 6945 RVA: 0x00097014 File Offset: 0x00095214
		// (set) Token: 0x06001B22 RID: 6946 RVA: 0x0000B031 File Offset: 0x00009231
		public unsafe static int jNwxjQilyePbFeoWPyFoqMeoVFo
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_jNwxjQilyePbFeoWPyFoqMeoVFo, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_jNwxjQilyePbFeoWPyFoqMeoVFo, (void*)(&value));
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06001B23 RID: 6947 RVA: 0x00097030 File Offset: 0x00095230
		// (set) Token: 0x06001B24 RID: 6948 RVA: 0x0000B03F File Offset: 0x0000923F
		public unsafe static int FXtDWUVkUWyrNZDVfPmoAYzjdSk
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_FXtDWUVkUWyrNZDVfPmoAYzjdSk, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_FXtDWUVkUWyrNZDVfPmoAYzjdSk, (void*)(&value));
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06001B25 RID: 6949 RVA: 0x0009704C File Offset: 0x0009524C
		// (set) Token: 0x06001B26 RID: 6950 RVA: 0x0000B04D File Offset: 0x0000924D
		public unsafe static int XSDHwGduufZGdjcfZNgipchoaDh
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_XSDHwGduufZGdjcfZNgipchoaDh, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_XSDHwGduufZGdjcfZNgipchoaDh, (void*)(&value));
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06001B27 RID: 6951 RVA: 0x00097068 File Offset: 0x00095268
		// (set) Token: 0x06001B28 RID: 6952 RVA: 0x0000B05B File Offset: 0x0000925B
		public unsafe static int KbJfnNWgRWWhYQPqfyOdakWTCzV
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_KbJfnNWgRWWhYQPqfyOdakWTCzV, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_KbJfnNWgRWWhYQPqfyOdakWTCzV, (void*)(&value));
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06001B29 RID: 6953 RVA: 0x00097084 File Offset: 0x00095284
		// (set) Token: 0x06001B2A RID: 6954 RVA: 0x0000B069 File Offset: 0x00009269
		public unsafe static int pGMNRoiPiXVgurNedyumDvLSWye
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_pGMNRoiPiXVgurNedyumDvLSWye, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_pGMNRoiPiXVgurNedyumDvLSWye, (void*)(&value));
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06001B2B RID: 6955 RVA: 0x000970A0 File Offset: 0x000952A0
		// (set) Token: 0x06001B2C RID: 6956 RVA: 0x0000B077 File Offset: 0x00009277
		public unsafe static int vnnAZtLgkFVwgtIbWVvtOytbiVQ
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_vnnAZtLgkFVwgtIbWVvtOytbiVQ, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_vnnAZtLgkFVwgtIbWVvtOytbiVQ, (void*)(&value));
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06001B2D RID: 6957 RVA: 0x000970BC File Offset: 0x000952BC
		// (set) Token: 0x06001B2E RID: 6958 RVA: 0x0000B085 File Offset: 0x00009285
		public unsafe static int EOghpTMwtDUuRuFBCAqiAhLpvK
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_EOghpTMwtDUuRuFBCAqiAhLpvK, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_EOghpTMwtDUuRuFBCAqiAhLpvK, (void*)(&value));
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06001B2F RID: 6959 RVA: 0x000970D8 File Offset: 0x000952D8
		// (set) Token: 0x06001B30 RID: 6960 RVA: 0x0000B093 File Offset: 0x00009293
		public unsafe static int qVDotNVsrZIVnBEmMnFuVBdendu
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_qVDotNVsrZIVnBEmMnFuVBdendu, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_qVDotNVsrZIVnBEmMnFuVBdendu, (void*)(&value));
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06001B31 RID: 6961 RVA: 0x000970F4 File Offset: 0x000952F4
		// (set) Token: 0x06001B32 RID: 6962 RVA: 0x0000B0A1 File Offset: 0x000092A1
		public unsafe static int hcBaVJxFQfmUjEoteGSzULttyVK
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_hcBaVJxFQfmUjEoteGSzULttyVK, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_hcBaVJxFQfmUjEoteGSzULttyVK, (void*)(&value));
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06001B33 RID: 6963 RVA: 0x00097110 File Offset: 0x00095310
		// (set) Token: 0x06001B34 RID: 6964 RVA: 0x0000B0AF File Offset: 0x000092AF
		public unsafe static int CCVbhVJfxwwdDigIhqkdBPtgRraU
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_CCVbhVJfxwwdDigIhqkdBPtgRraU, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_CCVbhVJfxwwdDigIhqkdBPtgRraU, (void*)(&value));
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06001B35 RID: 6965 RVA: 0x0009712C File Offset: 0x0009532C
		// (set) Token: 0x06001B36 RID: 6966 RVA: 0x0000B0BD File Offset: 0x000092BD
		public unsafe static int BBxhpfDMNTIyFeBupCZIVerwBWD
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_BBxhpfDMNTIyFeBupCZIVerwBWD, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_BBxhpfDMNTIyFeBupCZIVerwBWD, (void*)(&value));
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06001B37 RID: 6967 RVA: 0x00097148 File Offset: 0x00095348
		// (set) Token: 0x06001B38 RID: 6968 RVA: 0x0000B0CB File Offset: 0x000092CB
		public unsafe static int DjKakIgesLnAHNafOLmjWaZijsjK
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_DjKakIgesLnAHNafOLmjWaZijsjK, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_DjKakIgesLnAHNafOLmjWaZijsjK, (void*)(&value));
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06001B39 RID: 6969 RVA: 0x00097164 File Offset: 0x00095364
		// (set) Token: 0x06001B3A RID: 6970 RVA: 0x0000B0D9 File Offset: 0x000092D9
		public unsafe static int foWgjLXVSVMFiWVEEVhFNgtUENi
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_foWgjLXVSVMFiWVEEVhFNgtUENi, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_foWgjLXVSVMFiWVEEVhFNgtUENi, (void*)(&value));
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06001B3B RID: 6971 RVA: 0x00097180 File Offset: 0x00095380
		// (set) Token: 0x06001B3C RID: 6972 RVA: 0x0000B0E7 File Offset: 0x000092E7
		public unsafe static int yNXkfmYzMlAdJuzyPdItIntpuRG
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_yNXkfmYzMlAdJuzyPdItIntpuRG, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_yNXkfmYzMlAdJuzyPdItIntpuRG, (void*)(&value));
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06001B3D RID: 6973 RVA: 0x0009719C File Offset: 0x0009539C
		// (set) Token: 0x06001B3E RID: 6974 RVA: 0x0000B0F5 File Offset: 0x000092F5
		public unsafe static int izvXmSrSPbVoCbIocjuxlbdJFKp
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_izvXmSrSPbVoCbIocjuxlbdJFKp, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_izvXmSrSPbVoCbIocjuxlbdJFKp, (void*)(&value));
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06001B3F RID: 6975 RVA: 0x000971B8 File Offset: 0x000953B8
		// (set) Token: 0x06001B40 RID: 6976 RVA: 0x0000B103 File Offset: 0x00009303
		public unsafe static int geesShSZbWMRDQXWdWhQsuPIYbg
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_geesShSZbWMRDQXWdWhQsuPIYbg, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_geesShSZbWMRDQXWdWhQsuPIYbg, (void*)(&value));
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001B41 RID: 6977 RVA: 0x000971D4 File Offset: 0x000953D4
		// (set) Token: 0x06001B42 RID: 6978 RVA: 0x0000B111 File Offset: 0x00009311
		public unsafe static int EsFJPdDRcznZMMLQtKTzZswcLZN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_EsFJPdDRcznZMMLQtKTzZswcLZN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_EsFJPdDRcznZMMLQtKTzZswcLZN, (void*)(&value));
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06001B43 RID: 6979 RVA: 0x000971F0 File Offset: 0x000953F0
		// (set) Token: 0x06001B44 RID: 6980 RVA: 0x0000B11F File Offset: 0x0000931F
		public unsafe static int DfBydhNWOOkPYugrHJaqMYmzYxW
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_DfBydhNWOOkPYugrHJaqMYmzYxW, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_DfBydhNWOOkPYugrHJaqMYmzYxW, (void*)(&value));
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06001B45 RID: 6981 RVA: 0x0009720C File Offset: 0x0009540C
		// (set) Token: 0x06001B46 RID: 6982 RVA: 0x0000B12D File Offset: 0x0000932D
		public unsafe static int axsAWDoBfYTvKuiIBVCENVMNClI
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_axsAWDoBfYTvKuiIBVCENVMNClI, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_axsAWDoBfYTvKuiIBVCENVMNClI, (void*)(&value));
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x00097228 File Offset: 0x00095428
		// (set) Token: 0x06001B48 RID: 6984 RVA: 0x0000B13B File Offset: 0x0000933B
		public unsafe static int RkmXSIwacUHALbRdEDzDbXwbiNm
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_RkmXSIwacUHALbRdEDzDbXwbiNm, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_RkmXSIwacUHALbRdEDzDbXwbiNm, (void*)(&value));
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06001B49 RID: 6985 RVA: 0x00097244 File Offset: 0x00095444
		// (set) Token: 0x06001B4A RID: 6986 RVA: 0x0000B149 File Offset: 0x00009349
		public unsafe static int zNJxXdOIpKiDcgASoCbBJWVmwUT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_zNJxXdOIpKiDcgASoCbBJWVmwUT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_zNJxXdOIpKiDcgASoCbBJWVmwUT, (void*)(&value));
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06001B4B RID: 6987 RVA: 0x00097260 File Offset: 0x00095460
		// (set) Token: 0x06001B4C RID: 6988 RVA: 0x0000B157 File Offset: 0x00009357
		public unsafe static int RUqxFhXZXCJwBaIXjyWYPbcseaN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_RUqxFhXZXCJwBaIXjyWYPbcseaN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_RUqxFhXZXCJwBaIXjyWYPbcseaN, (void*)(&value));
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06001B4D RID: 6989 RVA: 0x0009727C File Offset: 0x0009547C
		// (set) Token: 0x06001B4E RID: 6990 RVA: 0x0000B165 File Offset: 0x00009365
		public unsafe static int XBkDTaPuOgAzSaajZefNYCwjBVjF
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_XBkDTaPuOgAzSaajZefNYCwjBVjF, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_XBkDTaPuOgAzSaajZefNYCwjBVjF, (void*)(&value));
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x00097298 File Offset: 0x00095498
		// (set) Token: 0x06001B50 RID: 6992 RVA: 0x0000B173 File Offset: 0x00009373
		public unsafe static int HCtvxTtdKBvBsmGhirWtPRCQIHe
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_HCtvxTtdKBvBsmGhirWtPRCQIHe, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_HCtvxTtdKBvBsmGhirWtPRCQIHe, (void*)(&value));
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x000972B4 File Offset: 0x000954B4
		// (set) Token: 0x06001B52 RID: 6994 RVA: 0x0000B181 File Offset: 0x00009381
		public unsafe static int YowfJgjPDjgBdWLQsQIkeMUIwCSG
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_YowfJgjPDjgBdWLQsQIkeMUIwCSG, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_YowfJgjPDjgBdWLQsQIkeMUIwCSG, (void*)(&value));
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x000972D0 File Offset: 0x000954D0
		// (set) Token: 0x06001B54 RID: 6996 RVA: 0x0000B18F File Offset: 0x0000938F
		public unsafe static bool fBLvQFYipvjtlfYVBgxEMoFHCiiB
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_fBLvQFYipvjtlfYVBgxEMoFHCiiB, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_fBLvQFYipvjtlfYVBgxEMoFHCiiB, (void*)(&value));
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06001B55 RID: 6997 RVA: 0x000972EC File Offset: 0x000954EC
		// (set) Token: 0x06001B56 RID: 6998 RVA: 0x0000B19D File Offset: 0x0000939D
		public unsafe static int SMoAnscTohLhkRCINmKDimcdDrha
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_SMoAnscTohLhkRCINmKDimcdDrha, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_SMoAnscTohLhkRCINmKDimcdDrha, (void*)(&value));
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06001B57 RID: 6999 RVA: 0x00097308 File Offset: 0x00095508
		// (set) Token: 0x06001B58 RID: 7000 RVA: 0x0000B1AB File Offset: 0x000093AB
		public unsafe static int ewAwOWPRZrTGiLDAAiOYHtWvayr
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_ewAwOWPRZrTGiLDAAiOYHtWvayr, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_ewAwOWPRZrTGiLDAAiOYHtWvayr, (void*)(&value));
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001B59 RID: 7001 RVA: 0x00097324 File Offset: 0x00095524
		// (set) Token: 0x06001B5A RID: 7002 RVA: 0x0000B1B9 File Offset: 0x000093B9
		public unsafe static float nbksJZgjBqdspiaJiKOmAmEioaiH
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_nbksJZgjBqdspiaJiKOmAmEioaiH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_nbksJZgjBqdspiaJiKOmAmEioaiH, (void*)(&value));
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06001B5B RID: 7003 RVA: 0x00097340 File Offset: 0x00095540
		// (set) Token: 0x06001B5C RID: 7004 RVA: 0x0000B1C7 File Offset: 0x000093C7
		public unsafe static float DugdatQgfbvfYbWbkKLDKCYLPaA
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_DugdatQgfbvfYbWbkKLDKCYLPaA, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_DugdatQgfbvfYbWbkKLDKCYLPaA, (void*)(&value));
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06001B5D RID: 7005 RVA: 0x0009735C File Offset: 0x0009555C
		// (set) Token: 0x06001B5E RID: 7006 RVA: 0x0000B1D5 File Offset: 0x000093D5
		public unsafe static float DAUINcLKpAQacqmWMUIzRBtPWQi
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_DAUINcLKpAQacqmWMUIzRBtPWQi, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_DAUINcLKpAQacqmWMUIzRBtPWQi, (void*)(&value));
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06001B5F RID: 7007 RVA: 0x00097378 File Offset: 0x00095578
		// (set) Token: 0x06001B60 RID: 7008 RVA: 0x0000B1E3 File Offset: 0x000093E3
		public unsafe static bool QYRvzOxFNpkSULNPpVRzHPlduSR
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_QYRvzOxFNpkSULNPpVRzHPlduSR, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_QYRvzOxFNpkSULNPpVRzHPlduSR, (void*)(&value));
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06001B61 RID: 7009 RVA: 0x00097394 File Offset: 0x00095594
		// (set) Token: 0x06001B62 RID: 7010 RVA: 0x0000B1F1 File Offset: 0x000093F1
		public unsafe static bool ercldrMDMwXEPurVOaoJxnVVpls
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_ercldrMDMwXEPurVOaoJxnVVpls, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_ercldrMDMwXEPurVOaoJxnVVpls, (void*)(&value));
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06001B63 RID: 7011 RVA: 0x000973B0 File Offset: 0x000955B0
		// (set) Token: 0x06001B64 RID: 7012 RVA: 0x0000B1FF File Offset: 0x000093FF
		public unsafe static bool YPjwmLyiGMgZqaXDYTZImQRTYEO
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_YPjwmLyiGMgZqaXDYTZImQRTYEO, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_YPjwmLyiGMgZqaXDYTZImQRTYEO, (void*)(&value));
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06001B65 RID: 7013 RVA: 0x000973CC File Offset: 0x000955CC
		// (set) Token: 0x06001B66 RID: 7014 RVA: 0x0000B20D File Offset: 0x0000940D
		public unsafe static bool OPYDCjKKkittUJrThlfyTQNZWEIG
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_OPYDCjKKkittUJrThlfyTQNZWEIG, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_OPYDCjKKkittUJrThlfyTQNZWEIG, (void*)(&value));
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06001B67 RID: 7015 RVA: 0x000973E8 File Offset: 0x000955E8
		// (set) Token: 0x06001B68 RID: 7016 RVA: 0x0000B21B File Offset: 0x0000941B
		public unsafe static float mjBnEAbcHYxisFdFlFoFkBglZOBn
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_mjBnEAbcHYxisFdFlFoFkBglZOBn, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_mjBnEAbcHYxisFdFlFoFkBglZOBn, (void*)(&value));
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06001B69 RID: 7017 RVA: 0x00097404 File Offset: 0x00095604
		// (set) Token: 0x06001B6A RID: 7018 RVA: 0x0000B229 File Offset: 0x00009429
		public unsafe static float VFDHHQcZdJhoVuZYXYHsXvpfeOL
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_VFDHHQcZdJhoVuZYXYHsXvpfeOL, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_VFDHHQcZdJhoVuZYXYHsXvpfeOL, (void*)(&value));
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06001B6B RID: 7019 RVA: 0x00097420 File Offset: 0x00095620
		// (set) Token: 0x06001B6C RID: 7020 RVA: 0x0000B237 File Offset: 0x00009437
		public unsafe static float MXGPRGAXeZnmaeVJRhyPEaVTkXQ
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_MXGPRGAXeZnmaeVJRhyPEaVTkXQ, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_MXGPRGAXeZnmaeVJRhyPEaVTkXQ, (void*)(&value));
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06001B6D RID: 7021 RVA: 0x0009743C File Offset: 0x0009563C
		// (set) Token: 0x06001B6E RID: 7022 RVA: 0x0000B245 File Offset: 0x00009445
		public unsafe static float TUDBImFUfxFLWRotJFCpRJvzDZa
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_TUDBImFUfxFLWRotJFCpRJvzDZa, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_TUDBImFUfxFLWRotJFCpRJvzDZa, (void*)(&value));
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001B6F RID: 7023 RVA: 0x00097458 File Offset: 0x00095658
		// (set) Token: 0x06001B70 RID: 7024 RVA: 0x0000B253 File Offset: 0x00009453
		public unsafe static float bkfuctINqlGyShIdchJBqLCYxstJ
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_bkfuctINqlGyShIdchJBqLCYxstJ, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_bkfuctINqlGyShIdchJBqLCYxstJ, (void*)(&value));
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06001B71 RID: 7025 RVA: 0x00097474 File Offset: 0x00095674
		// (set) Token: 0x06001B72 RID: 7026 RVA: 0x0000B261 File Offset: 0x00009461
		public unsafe static float ckzrduSceznhfUkVNVzAlrFMzOk
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_ckzrduSceznhfUkVNVzAlrFMzOk, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_ckzrduSceznhfUkVNVzAlrFMzOk, (void*)(&value));
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06001B73 RID: 7027 RVA: 0x00097490 File Offset: 0x00095690
		// (set) Token: 0x06001B74 RID: 7028 RVA: 0x0000B26F File Offset: 0x0000946F
		public unsafe static float lXKFeRBfejoFIuuyCCeCQPgXmdAP
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_lXKFeRBfejoFIuuyCCeCQPgXmdAP, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_lXKFeRBfejoFIuuyCCeCQPgXmdAP, (void*)(&value));
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06001B75 RID: 7029 RVA: 0x000974AC File Offset: 0x000956AC
		// (set) Token: 0x06001B76 RID: 7030 RVA: 0x0000B27D File Offset: 0x0000947D
		public unsafe static float qDdCVvKQZbrijiZvgipubafbXOo
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_qDdCVvKQZbrijiZvgipubafbXOo, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_qDdCVvKQZbrijiZvgipubafbXOo, (void*)(&value));
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06001B77 RID: 7031 RVA: 0x000974C8 File Offset: 0x000956C8
		// (set) Token: 0x06001B78 RID: 7032 RVA: 0x0000B28B File Offset: 0x0000948B
		public unsafe static float LcPJePsNJDGRzaAichDdYIgnONuI
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_LcPJePsNJDGRzaAichDdYIgnONuI, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_LcPJePsNJDGRzaAichDdYIgnONuI, (void*)(&value));
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06001B79 RID: 7033 RVA: 0x000974E4 File Offset: 0x000956E4
		// (set) Token: 0x06001B7A RID: 7034 RVA: 0x0000B299 File Offset: 0x00009499
		public unsafe static uint zMjchRqKunNBMOIYPuLIpiVGqId
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_zMjchRqKunNBMOIYPuLIpiVGqId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_zMjchRqKunNBMOIYPuLIpiVGqId, (void*)(&value));
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06001B7B RID: 7035 RVA: 0x00097500 File Offset: 0x00095700
		// (set) Token: 0x06001B7C RID: 7036 RVA: 0x0000B2A7 File Offset: 0x000094A7
		public unsafe bool hbVTfeoNOpiGfjtSvuUJcKveeIPP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_hbVTfeoNOpiGfjtSvuUJcKveeIPP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_hbVTfeoNOpiGfjtSvuUJcKveeIPP)) = value;
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001B7D RID: 7037 RVA: 0x00097528 File Offset: 0x00095728
		// (set) Token: 0x06001B7E RID: 7038 RVA: 0x0000B2C2 File Offset: 0x000094C2
		public unsafe int egeIAYGpUfUEQnQHRNtccoCwhkb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_egeIAYGpUfUEQnQHRNtccoCwhkb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_egeIAYGpUfUEQnQHRNtccoCwhkb)) = value;
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06001B7F RID: 7039 RVA: 0x00097550 File Offset: 0x00095750
		// (set) Token: 0x06001B80 RID: 7040 RVA: 0x0000B2DD File Offset: 0x000094DD
		public unsafe int uBCvvZAaNoajgRatNflOHdudRbrB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_uBCvvZAaNoajgRatNflOHdudRbrB);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_uBCvvZAaNoajgRatNflOHdudRbrB)) = value;
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06001B81 RID: 7041 RVA: 0x00097578 File Offset: 0x00095778
		// (set) Token: 0x06001B82 RID: 7042 RVA: 0x0000B2F8 File Offset: 0x000094F8
		public unsafe bool mPARfXQHiXPIiWsEdawLAmEocmM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_mPARfXQHiXPIiWsEdawLAmEocmM);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_mPARfXQHiXPIiWsEdawLAmEocmM)) = value;
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06001B83 RID: 7043 RVA: 0x000975A0 File Offset: 0x000957A0
		// (set) Token: 0x06001B84 RID: 7044 RVA: 0x0000B313 File Offset: 0x00009513
		public unsafe byte tmIocfPzYqSkyWAsAqKlPqHeQyA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_tmIocfPzYqSkyWAsAqKlPqHeQyA);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_tmIocfPzYqSkyWAsAqKlPqHeQyA)) = value;
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001B85 RID: 7045 RVA: 0x000975C8 File Offset: 0x000957C8
		// (set) Token: 0x06001B86 RID: 7046 RVA: 0x0000B32E File Offset: 0x0000952E
		public unsafe int rWuGSHcFIrSEtLmEWnwNAAMIkTQh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_rWuGSHcFIrSEtLmEWnwNAAMIkTQh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_rWuGSHcFIrSEtLmEWnwNAAMIkTQh)) = value;
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001B87 RID: 7047 RVA: 0x000975F0 File Offset: 0x000957F0
		// (set) Token: 0x06001B88 RID: 7048 RVA: 0x0000B349 File Offset: 0x00009549
		public unsafe int FXCndKilsLeiQIcUSfpHzZDAPmwF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_FXCndKilsLeiQIcUSfpHzZDAPmwF);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_FXCndKilsLeiQIcUSfpHzZDAPmwF)) = value;
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001B89 RID: 7049 RVA: 0x00097618 File Offset: 0x00095818
		// (set) Token: 0x06001B8A RID: 7050 RVA: 0x0000B364 File Offset: 0x00009564
		public unsafe int fxDKuXoXhRfNScEQSkchCEEpvBY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_fxDKuXoXhRfNScEQSkchCEEpvBY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_fxDKuXoXhRfNScEQSkchCEEpvBY)) = value;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06001B8B RID: 7051 RVA: 0x00097640 File Offset: 0x00095840
		// (set) Token: 0x06001B8C RID: 7052 RVA: 0x0000B37F File Offset: 0x0000957F
		public unsafe int dBoIMedCMyQNHjRaJpngjHJXfMdE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_dBoIMedCMyQNHjRaJpngjHJXfMdE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_dBoIMedCMyQNHjRaJpngjHJXfMdE)) = value;
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001B8D RID: 7053 RVA: 0x00097668 File Offset: 0x00095868
		// (set) Token: 0x06001B8E RID: 7054 RVA: 0x0000B39A File Offset: 0x0000959A
		public unsafe int izYKmDpxFzOrqRbOivvudHllUsE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_izYKmDpxFzOrqRbOivvudHllUsE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_izYKmDpxFzOrqRbOivvudHllUsE)) = value;
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06001B8F RID: 7055 RVA: 0x00097690 File Offset: 0x00095890
		// (set) Token: 0x06001B90 RID: 7056 RVA: 0x0000B3B5 File Offset: 0x000095B5
		public unsafe int GeDQfGevPhhOtATwmXkLyHvWccw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_GeDQfGevPhhOtATwmXkLyHvWccw);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_GeDQfGevPhhOtATwmXkLyHvWccw)) = value;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001B91 RID: 7057 RVA: 0x000976B8 File Offset: 0x000958B8
		// (set) Token: 0x06001B92 RID: 7058 RVA: 0x0000B3D0 File Offset: 0x000095D0
		public unsafe NativeBuffer VqjireeisHBGAbOmixQcKOQABZY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_VqjireeisHBGAbOmixQcKOQABZY);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NativeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_VqjireeisHBGAbOmixQcKOQABZY), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001B93 RID: 7059 RVA: 0x000976E8 File Offset: 0x000958E8
		// (set) Token: 0x06001B94 RID: 7060 RVA: 0x0000B3EF File Offset: 0x000095EF
		public unsafe NativeBuffer SEQenGfoIoNZmaGLiQDgmYcHfBRG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_SEQenGfoIoNZmaGLiQDgmYcHfBRG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NativeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_SEQenGfoIoNZmaGLiQDgmYcHfBRG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001B95 RID: 7061 RVA: 0x00097718 File Offset: 0x00095918
		// (set) Token: 0x06001B96 RID: 7062 RVA: 0x0000B40E File Offset: 0x0000960E
		public unsafe OutputReport NXVqXgfUsQHbVRrEpuYEreBlzpN
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_NXVqXgfUsQHbVRrEpuYEreBlzpN);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_NXVqXgfUsQHbVRrEpuYEreBlzpN)) = value;
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06001B97 RID: 7063 RVA: 0x00097740 File Offset: 0x00095940
		// (set) Token: 0x06001B98 RID: 7064 RVA: 0x0000B429 File Offset: 0x00009629
		public unsafe Func<OutputReport, bool> dzydtpDkcOlbZPaRhVbfGNBdrDQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_dzydtpDkcOlbZPaRhVbfGNBdrDQ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<OutputReport, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_dzydtpDkcOlbZPaRhVbfGNBdrDQ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06001B99 RID: 7065 RVA: 0x00097770 File Offset: 0x00095970
		// (set) Token: 0x06001B9A RID: 7066 RVA: 0x0000B448 File Offset: 0x00009648
		public unsafe Action<OutputReport> MqcIIdsSwUqQdRoXaTgVghcDhrW
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_MqcIIdsSwUqQdRoXaTgVghcDhrW);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<OutputReport>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_MqcIIdsSwUqQdRoXaTgVghcDhrW), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06001B9B RID: 7067 RVA: 0x000977A0 File Offset: 0x000959A0
		// (set) Token: 0x06001B9C RID: 7068 RVA: 0x0000B467 File Offset: 0x00009667
		public unsafe bool WiKTTbpsgABuAkMhYSavFVjifRv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_WiKTTbpsgABuAkMhYSavFVjifRv);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_WiKTTbpsgABuAkMhYSavFVjifRv)) = value;
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06001B9D RID: 7069 RVA: 0x000977C8 File Offset: 0x000959C8
		// (set) Token: 0x06001B9E RID: 7070 RVA: 0x0000B482 File Offset: 0x00009682
		public unsafe bool GjYzRFszhGQQgQSGrnIRVGWAJXr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_GjYzRFszhGQQgQSGrnIRVGWAJXr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_GjYzRFszhGQQgQSGrnIRVGWAJXr)) = value;
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001B9F RID: 7071 RVA: 0x000977F0 File Offset: 0x000959F0
		// (set) Token: 0x06001BA0 RID: 7072 RVA: 0x0000B49D File Offset: 0x0000969D
		public unsafe double vWODbbChHxjsJwFcccLzWSgbQGAI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_vWODbbChHxjsJwFcccLzWSgbQGAI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_vWODbbChHxjsJwFcccLzWSgbQGAI)) = value;
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x00097818 File Offset: 0x00095A18
		// (set) Token: 0x06001BA2 RID: 7074 RVA: 0x0000B4B8 File Offset: 0x000096B8
		public unsafe byte XVfeDFKQSiWWjEnCYqeBmfVLANBm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_XVfeDFKQSiWWjEnCYqeBmfVLANBm);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_XVfeDFKQSiWWjEnCYqeBmfVLANBm)) = value;
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x00097840 File Offset: 0x00095A40
		// (set) Token: 0x06001BA4 RID: 7076 RVA: 0x0000B4D3 File Offset: 0x000096D3
		public unsafe bool UGsfEPbEftfDkZDHEhvZKzvpejCh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_UGsfEPbEftfDkZDHEhvZKzvpejCh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_UGsfEPbEftfDkZDHEhvZKzvpejCh)) = value;
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06001BA5 RID: 7077 RVA: 0x00097868 File Offset: 0x00095A68
		// (set) Token: 0x06001BA6 RID: 7078 RVA: 0x0000B4EE File Offset: 0x000096EE
		public unsafe bool ZMBMGVjsrAkVGgxKxyCxRULydmm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_ZMBMGVjsrAkVGgxKxyCxRULydmm);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_ZMBMGVjsrAkVGgxKxyCxRULydmm)) = value;
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06001BA7 RID: 7079 RVA: 0x00097890 File Offset: 0x00095A90
		// (set) Token: 0x06001BA8 RID: 7080 RVA: 0x0000B509 File Offset: 0x00009709
		public unsafe bool ONdUFSUycItfOpOkWTvesaAwuVs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_ONdUFSUycItfOpOkWTvesaAwuVs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_ONdUFSUycItfOpOkWTvesaAwuVs)) = value;
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06001BA9 RID: 7081 RVA: 0x000978B8 File Offset: 0x00095AB8
		// (set) Token: 0x06001BAA RID: 7082 RVA: 0x0000B524 File Offset: 0x00009724
		public unsafe Quaternion kEQdqkMxSYRqzzGPHAxtXPlPzkZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_kEQdqkMxSYRqzzGPHAxtXPlPzkZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_kEQdqkMxSYRqzzGPHAxtXPlPzkZ)) = value;
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06001BAB RID: 7083 RVA: 0x000978E0 File Offset: 0x00095AE0
		// (set) Token: 0x06001BAC RID: 7084 RVA: 0x0000B53F File Offset: 0x0000973F
		public unsafe DualSenseMicrophoneLightMode WCfDoojgzpSlStzOsMyPeCbQeaJj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_WCfDoojgzpSlStzOsMyPeCbQeaJj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_WCfDoojgzpSlStzOsMyPeCbQeaJj)) = value;
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06001BAD RID: 7085 RVA: 0x00097908 File Offset: 0x00095B08
		// (set) Token: 0x06001BAE RID: 7086 RVA: 0x0000B55A File Offset: 0x0000975A
		public unsafe DualSenseDriver.uASSUXqpRKvdvBmSBaslDYQnViNe kQKpjVOkPcBOqzzgUcfedubZWIg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_kQKpjVOkPcBOqzzgUcfedubZWIg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_kQKpjVOkPcBOqzzgUcfedubZWIg)) = value;
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06001BAF RID: 7087 RVA: 0x00097930 File Offset: 0x00095B30
		// (set) Token: 0x06001BB0 RID: 7088 RVA: 0x0000B575 File Offset: 0x00009775
		public unsafe DualSensePlayerLightFlags lGFnvrVsYXArhmLqurfppgtHXZR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_lGFnvrVsYXArhmLqurfppgtHXZR);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_lGFnvrVsYXArhmLqurfppgtHXZR)) = value;
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06001BB1 RID: 7089 RVA: 0x00097958 File Offset: 0x00095B58
		// (set) Token: 0x06001BB2 RID: 7090 RVA: 0x0000B590 File Offset: 0x00009790
		public unsafe bool FickyNoxMCrkMPcgwygIhassLQk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_FickyNoxMCrkMPcgwygIhassLQk);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_FickyNoxMCrkMPcgwygIhassLQk)) = value;
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001BB3 RID: 7091 RVA: 0x00097980 File Offset: 0x00095B80
		// (set) Token: 0x06001BB4 RID: 7092 RVA: 0x0000B5AB File Offset: 0x000097AB
		public unsafe bool EscSNlnNIwRgGQmzBHNegrWcYDH
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_EscSNlnNIwRgGQmzBHNegrWcYDH);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_EscSNlnNIwRgGQmzBHNegrWcYDH)) = value;
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x000979A8 File Offset: 0x00095BA8
		// (set) Token: 0x06001BB6 RID: 7094 RVA: 0x0000B5C6 File Offset: 0x000097C6
		public unsafe uint RTKlxLjGuZLRqfVuXrlNDhwBiTy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_RTKlxLjGuZLRqfVuXrlNDhwBiTy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_RTKlxLjGuZLRqfVuXrlNDhwBiTy)) = value;
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x000979D0 File Offset: 0x00095BD0
		// (set) Token: 0x06001BB8 RID: 7096 RVA: 0x0000B5E1 File Offset: 0x000097E1
		public unsafe float ippVKLLMqIBFhRtXoenvVQntAJd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_ippVKLLMqIBFhRtXoenvVQntAJd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_ippVKLLMqIBFhRtXoenvVQntAJd)) = value;
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x000979F8 File Offset: 0x00095BF8
		// (set) Token: 0x06001BBA RID: 7098 RVA: 0x0000B5FC File Offset: 0x000097FC
		public unsafe double qjntYfLoESbAWHDBNDGxRCXJMfy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_qjntYfLoESbAWHDBNDGxRCXJMfy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_qjntYfLoESbAWHDBNDGxRCXJMfy)) = value;
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06001BBB RID: 7099 RVA: 0x00097A20 File Offset: 0x00095C20
		// (set) Token: 0x06001BBC RID: 7100 RVA: 0x0000B617 File Offset: 0x00009817
		public unsafe float XnRnoVdLhJkUOHOAQhipOOfFLpk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_XnRnoVdLhJkUOHOAQhipOOfFLpk);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_XnRnoVdLhJkUOHOAQhipOOfFLpk)) = value;
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06001BBD RID: 7101 RVA: 0x00097A48 File Offset: 0x00095C48
		// (set) Token: 0x06001BBE RID: 7102 RVA: 0x0000B632 File Offset: 0x00009832
		public unsafe byte bUbhTMCGWaCoOqSuDMxcebgtRqzV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_bUbhTMCGWaCoOqSuDMxcebgtRqzV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_bUbhTMCGWaCoOqSuDMxcebgtRqzV)) = value;
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06001BBF RID: 7103 RVA: 0x00097A70 File Offset: 0x00095C70
		// (set) Token: 0x06001BC0 RID: 7104 RVA: 0x0000B64D File Offset: 0x0000984D
		public unsafe byte OLKxRVqOsIErBUQFLStrlOJjitj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_OLKxRVqOsIErBUQFLStrlOJjitj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_OLKxRVqOsIErBUQFLStrlOJjitj)) = value;
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001BC1 RID: 7105 RVA: 0x00097A98 File Offset: 0x00095C98
		// (set) Token: 0x06001BC2 RID: 7106 RVA: 0x0000B668 File Offset: 0x00009868
		public unsafe Quaternion oHPGAxVesPYWMwkICufJHTEytZG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_oHPGAxVesPYWMwkICufJHTEytZG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_oHPGAxVesPYWMwkICufJHTEytZG)) = value;
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06001BC3 RID: 7107 RVA: 0x00097AC0 File Offset: 0x00095CC0
		// (set) Token: 0x06001BC4 RID: 7108 RVA: 0x0000B683 File Offset: 0x00009883
		public unsafe Quaternion nQtUtyADXujDLjRfcvigVPkcmUX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_nQtUtyADXujDLjRfcvigVPkcmUX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_nQtUtyADXujDLjRfcvigVPkcmUX)) = value;
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x00097AE8 File Offset: 0x00095CE8
		// (set) Token: 0x06001BC6 RID: 7110 RVA: 0x0000B69E File Offset: 0x0000989E
		public unsafe bool pmmntafFsJVEOxFZPqxaaiZpAMO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_pmmntafFsJVEOxFZPqxaaiZpAMO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_pmmntafFsJVEOxFZPqxaaiZpAMO)) = value;
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06001BC7 RID: 7111 RVA: 0x00097B10 File Offset: 0x00095D10
		// (set) Token: 0x06001BC8 RID: 7112 RVA: 0x0000B6B9 File Offset: 0x000098B9
		public unsafe int aOwynHDBqdQEJSMuGFrjRNscfyAD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_aOwynHDBqdQEJSMuGFrjRNscfyAD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_aOwynHDBqdQEJSMuGFrjRNscfyAD)) = value;
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06001BC9 RID: 7113 RVA: 0x00097B38 File Offset: 0x00095D38
		// (set) Token: 0x06001BCA RID: 7114 RVA: 0x0000B6D4 File Offset: 0x000098D4
		public unsafe Il2CppStructArray<int> oTQFLvxokTfPetxLSxzfnaixHvs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_oTQFLvxokTfPetxLSxzfnaixHvs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_oTQFLvxokTfPetxLSxzfnaixHvs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06001BCB RID: 7115 RVA: 0x00097B68 File Offset: 0x00095D68
		// (set) Token: 0x06001BCC RID: 7116 RVA: 0x0000B6F3 File Offset: 0x000098F3
		public unsafe Il2CppStructArray<int> DhbhSRVhmFGIEaEXjUaEnRbxQZd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_DhbhSRVhmFGIEaEXjUaEnRbxQZd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DualSenseDriver.NativeFieldInfoPtr_DhbhSRVhmFGIEaEXjUaEnRbxQZd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06001BCD RID: 7117 RVA: 0x00097B98 File Offset: 0x00095D98
		// (set) Token: 0x06001BCE RID: 7118 RVA: 0x0000B712 File Offset: 0x00009912
		public unsafe static Il2CppStructArray<uint> oYSRduOYkhJTOKlJmpGdAomDMXu
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DualSenseDriver.NativeFieldInfoPtr_oYSRduOYkhJTOKlJmpGdAomDMXu, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DualSenseDriver.NativeFieldInfoPtr_oYSRduOYkhJTOKlJmpGdAomDMXu, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016D4 RID: 5844
		private static readonly IntPtr NativeFieldInfoPtr_cBswOuBTFJaQmJaEsTSUwghjEsxb;

		// Token: 0x040016D5 RID: 5845
		private static readonly IntPtr NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm;

		// Token: 0x040016D6 RID: 5846
		private static readonly IntPtr NativeFieldInfoPtr_ZSAekMXsJdpwJeuHzaalTvrqTXZ;

		// Token: 0x040016D7 RID: 5847
		private static readonly IntPtr NativeFieldInfoPtr_xQFBlnjHmSMxSYBxUcplNCrUIpHy;

		// Token: 0x040016D8 RID: 5848
		private static readonly IntPtr NativeFieldInfoPtr_DXQOduZMAdakgKHULREouGGIMsj;

		// Token: 0x040016D9 RID: 5849
		private static readonly IntPtr NativeFieldInfoPtr_jkpagfZjLjeageiKHUvdcGIBUyjQ;

		// Token: 0x040016DA RID: 5850
		private static readonly IntPtr NativeFieldInfoPtr_CbvTpyUAreHQTqRwrRyHFkkvRu;

		// Token: 0x040016DB RID: 5851
		private static readonly IntPtr NativeFieldInfoPtr_qkfbSOvdxzFTGQsCjAxNayadEWhk;

		// Token: 0x040016DC RID: 5852
		private static readonly IntPtr NativeFieldInfoPtr_sstgLgFYucqXUgQCuJWZzpHiirhL;

		// Token: 0x040016DD RID: 5853
		private static readonly IntPtr NativeFieldInfoPtr_AHJqxkYPMecTbQnOZRgFvJYDGTg;

		// Token: 0x040016DE RID: 5854
		private static readonly IntPtr NativeFieldInfoPtr_ykFUEgafLAgAceDkWcqiMSzQgGhj;

		// Token: 0x040016DF RID: 5855
		private static readonly IntPtr NativeFieldInfoPtr_ucCwnEJshdgPokipDfKZUPXVGns;

		// Token: 0x040016E0 RID: 5856
		private static readonly IntPtr NativeFieldInfoPtr_HQywWIGQbJvUyoAzHWTXqleTChs;

		// Token: 0x040016E1 RID: 5857
		private static readonly IntPtr NativeFieldInfoPtr_cHNhpgkLYTObmpHxVWxLGMeDyrl;

		// Token: 0x040016E2 RID: 5858
		private static readonly IntPtr NativeFieldInfoPtr_iZucelPQVvvGHDiPkrqCheppWEb;

		// Token: 0x040016E3 RID: 5859
		private static readonly IntPtr NativeFieldInfoPtr_uxwENVeAtCyNlYtYwbcddIUTAOou;

		// Token: 0x040016E4 RID: 5860
		private static readonly IntPtr NativeFieldInfoPtr_LgKeAUHCkufZaobBGjJCDaKYadH;

		// Token: 0x040016E5 RID: 5861
		private static readonly IntPtr NativeFieldInfoPtr_jNwxjQilyePbFeoWPyFoqMeoVFo;

		// Token: 0x040016E6 RID: 5862
		private static readonly IntPtr NativeFieldInfoPtr_FXtDWUVkUWyrNZDVfPmoAYzjdSk;

		// Token: 0x040016E7 RID: 5863
		private static readonly IntPtr NativeFieldInfoPtr_XSDHwGduufZGdjcfZNgipchoaDh;

		// Token: 0x040016E8 RID: 5864
		private static readonly IntPtr NativeFieldInfoPtr_KbJfnNWgRWWhYQPqfyOdakWTCzV;

		// Token: 0x040016E9 RID: 5865
		private static readonly IntPtr NativeFieldInfoPtr_pGMNRoiPiXVgurNedyumDvLSWye;

		// Token: 0x040016EA RID: 5866
		private static readonly IntPtr NativeFieldInfoPtr_vnnAZtLgkFVwgtIbWVvtOytbiVQ;

		// Token: 0x040016EB RID: 5867
		private static readonly IntPtr NativeFieldInfoPtr_EOghpTMwtDUuRuFBCAqiAhLpvK;

		// Token: 0x040016EC RID: 5868
		private static readonly IntPtr NativeFieldInfoPtr_qVDotNVsrZIVnBEmMnFuVBdendu;

		// Token: 0x040016ED RID: 5869
		private static readonly IntPtr NativeFieldInfoPtr_hcBaVJxFQfmUjEoteGSzULttyVK;

		// Token: 0x040016EE RID: 5870
		private static readonly IntPtr NativeFieldInfoPtr_CCVbhVJfxwwdDigIhqkdBPtgRraU;

		// Token: 0x040016EF RID: 5871
		private static readonly IntPtr NativeFieldInfoPtr_BBxhpfDMNTIyFeBupCZIVerwBWD;

		// Token: 0x040016F0 RID: 5872
		private static readonly IntPtr NativeFieldInfoPtr_DjKakIgesLnAHNafOLmjWaZijsjK;

		// Token: 0x040016F1 RID: 5873
		private static readonly IntPtr NativeFieldInfoPtr_foWgjLXVSVMFiWVEEVhFNgtUENi;

		// Token: 0x040016F2 RID: 5874
		private static readonly IntPtr NativeFieldInfoPtr_yNXkfmYzMlAdJuzyPdItIntpuRG;

		// Token: 0x040016F3 RID: 5875
		private static readonly IntPtr NativeFieldInfoPtr_izvXmSrSPbVoCbIocjuxlbdJFKp;

		// Token: 0x040016F4 RID: 5876
		private static readonly IntPtr NativeFieldInfoPtr_geesShSZbWMRDQXWdWhQsuPIYbg;

		// Token: 0x040016F5 RID: 5877
		private static readonly IntPtr NativeFieldInfoPtr_EsFJPdDRcznZMMLQtKTzZswcLZN;

		// Token: 0x040016F6 RID: 5878
		private static readonly IntPtr NativeFieldInfoPtr_DfBydhNWOOkPYugrHJaqMYmzYxW;

		// Token: 0x040016F7 RID: 5879
		private static readonly IntPtr NativeFieldInfoPtr_axsAWDoBfYTvKuiIBVCENVMNClI;

		// Token: 0x040016F8 RID: 5880
		private static readonly IntPtr NativeFieldInfoPtr_RkmXSIwacUHALbRdEDzDbXwbiNm;

		// Token: 0x040016F9 RID: 5881
		private static readonly IntPtr NativeFieldInfoPtr_zNJxXdOIpKiDcgASoCbBJWVmwUT;

		// Token: 0x040016FA RID: 5882
		private static readonly IntPtr NativeFieldInfoPtr_RUqxFhXZXCJwBaIXjyWYPbcseaN;

		// Token: 0x040016FB RID: 5883
		private static readonly IntPtr NativeFieldInfoPtr_XBkDTaPuOgAzSaajZefNYCwjBVjF;

		// Token: 0x040016FC RID: 5884
		private static readonly IntPtr NativeFieldInfoPtr_HCtvxTtdKBvBsmGhirWtPRCQIHe;

		// Token: 0x040016FD RID: 5885
		private static readonly IntPtr NativeFieldInfoPtr_YowfJgjPDjgBdWLQsQIkeMUIwCSG;

		// Token: 0x040016FE RID: 5886
		private static readonly IntPtr NativeFieldInfoPtr_fBLvQFYipvjtlfYVBgxEMoFHCiiB;

		// Token: 0x040016FF RID: 5887
		private static readonly IntPtr NativeFieldInfoPtr_SMoAnscTohLhkRCINmKDimcdDrha;

		// Token: 0x04001700 RID: 5888
		private static readonly IntPtr NativeFieldInfoPtr_ewAwOWPRZrTGiLDAAiOYHtWvayr;

		// Token: 0x04001701 RID: 5889
		private static readonly IntPtr NativeFieldInfoPtr_nbksJZgjBqdspiaJiKOmAmEioaiH;

		// Token: 0x04001702 RID: 5890
		private static readonly IntPtr NativeFieldInfoPtr_DugdatQgfbvfYbWbkKLDKCYLPaA;

		// Token: 0x04001703 RID: 5891
		private static readonly IntPtr NativeFieldInfoPtr_DAUINcLKpAQacqmWMUIzRBtPWQi;

		// Token: 0x04001704 RID: 5892
		private static readonly IntPtr NativeFieldInfoPtr_QYRvzOxFNpkSULNPpVRzHPlduSR;

		// Token: 0x04001705 RID: 5893
		private static readonly IntPtr NativeFieldInfoPtr_ercldrMDMwXEPurVOaoJxnVVpls;

		// Token: 0x04001706 RID: 5894
		private static readonly IntPtr NativeFieldInfoPtr_YPjwmLyiGMgZqaXDYTZImQRTYEO;

		// Token: 0x04001707 RID: 5895
		private static readonly IntPtr NativeFieldInfoPtr_OPYDCjKKkittUJrThlfyTQNZWEIG;

		// Token: 0x04001708 RID: 5896
		private static readonly IntPtr NativeFieldInfoPtr_mjBnEAbcHYxisFdFlFoFkBglZOBn;

		// Token: 0x04001709 RID: 5897
		private static readonly IntPtr NativeFieldInfoPtr_VFDHHQcZdJhoVuZYXYHsXvpfeOL;

		// Token: 0x0400170A RID: 5898
		private static readonly IntPtr NativeFieldInfoPtr_MXGPRGAXeZnmaeVJRhyPEaVTkXQ;

		// Token: 0x0400170B RID: 5899
		private static readonly IntPtr NativeFieldInfoPtr_TUDBImFUfxFLWRotJFCpRJvzDZa;

		// Token: 0x0400170C RID: 5900
		private static readonly IntPtr NativeFieldInfoPtr_bkfuctINqlGyShIdchJBqLCYxstJ;

		// Token: 0x0400170D RID: 5901
		private static readonly IntPtr NativeFieldInfoPtr_ckzrduSceznhfUkVNVzAlrFMzOk;

		// Token: 0x0400170E RID: 5902
		private static readonly IntPtr NativeFieldInfoPtr_lXKFeRBfejoFIuuyCCeCQPgXmdAP;

		// Token: 0x0400170F RID: 5903
		private static readonly IntPtr NativeFieldInfoPtr_qDdCVvKQZbrijiZvgipubafbXOo;

		// Token: 0x04001710 RID: 5904
		private static readonly IntPtr NativeFieldInfoPtr_LcPJePsNJDGRzaAichDdYIgnONuI;

		// Token: 0x04001711 RID: 5905
		private static readonly IntPtr NativeFieldInfoPtr_zMjchRqKunNBMOIYPuLIpiVGqId;

		// Token: 0x04001712 RID: 5906
		private static readonly IntPtr NativeFieldInfoPtr_hbVTfeoNOpiGfjtSvuUJcKveeIPP;

		// Token: 0x04001713 RID: 5907
		private static readonly IntPtr NativeFieldInfoPtr_egeIAYGpUfUEQnQHRNtccoCwhkb;

		// Token: 0x04001714 RID: 5908
		private static readonly IntPtr NativeFieldInfoPtr_uBCvvZAaNoajgRatNflOHdudRbrB;

		// Token: 0x04001715 RID: 5909
		private static readonly IntPtr NativeFieldInfoPtr_mPARfXQHiXPIiWsEdawLAmEocmM;

		// Token: 0x04001716 RID: 5910
		private static readonly IntPtr NativeFieldInfoPtr_tmIocfPzYqSkyWAsAqKlPqHeQyA;

		// Token: 0x04001717 RID: 5911
		private static readonly IntPtr NativeFieldInfoPtr_rWuGSHcFIrSEtLmEWnwNAAMIkTQh;

		// Token: 0x04001718 RID: 5912
		private static readonly IntPtr NativeFieldInfoPtr_FXCndKilsLeiQIcUSfpHzZDAPmwF;

		// Token: 0x04001719 RID: 5913
		private static readonly IntPtr NativeFieldInfoPtr_fxDKuXoXhRfNScEQSkchCEEpvBY;

		// Token: 0x0400171A RID: 5914
		private static readonly IntPtr NativeFieldInfoPtr_dBoIMedCMyQNHjRaJpngjHJXfMdE;

		// Token: 0x0400171B RID: 5915
		private static readonly IntPtr NativeFieldInfoPtr_izYKmDpxFzOrqRbOivvudHllUsE;

		// Token: 0x0400171C RID: 5916
		private static readonly IntPtr NativeFieldInfoPtr_GeDQfGevPhhOtATwmXkLyHvWccw;

		// Token: 0x0400171D RID: 5917
		private static readonly IntPtr NativeFieldInfoPtr_VqjireeisHBGAbOmixQcKOQABZY;

		// Token: 0x0400171E RID: 5918
		private static readonly IntPtr NativeFieldInfoPtr_SEQenGfoIoNZmaGLiQDgmYcHfBRG;

		// Token: 0x0400171F RID: 5919
		private static readonly IntPtr NativeFieldInfoPtr_NXVqXgfUsQHbVRrEpuYEreBlzpN;

		// Token: 0x04001720 RID: 5920
		private static readonly IntPtr NativeFieldInfoPtr_dzydtpDkcOlbZPaRhVbfGNBdrDQ;

		// Token: 0x04001721 RID: 5921
		private static readonly IntPtr NativeFieldInfoPtr_MqcIIdsSwUqQdRoXaTgVghcDhrW;

		// Token: 0x04001722 RID: 5922
		private static readonly IntPtr NativeFieldInfoPtr_WiKTTbpsgABuAkMhYSavFVjifRv;

		// Token: 0x04001723 RID: 5923
		private static readonly IntPtr NativeFieldInfoPtr_GjYzRFszhGQQgQSGrnIRVGWAJXr;

		// Token: 0x04001724 RID: 5924
		private static readonly IntPtr NativeFieldInfoPtr_vWODbbChHxjsJwFcccLzWSgbQGAI;

		// Token: 0x04001725 RID: 5925
		private static readonly IntPtr NativeFieldInfoPtr_XVfeDFKQSiWWjEnCYqeBmfVLANBm;

		// Token: 0x04001726 RID: 5926
		private static readonly IntPtr NativeFieldInfoPtr_UGsfEPbEftfDkZDHEhvZKzvpejCh;

		// Token: 0x04001727 RID: 5927
		private static readonly IntPtr NativeFieldInfoPtr_ZMBMGVjsrAkVGgxKxyCxRULydmm;

		// Token: 0x04001728 RID: 5928
		private static readonly IntPtr NativeFieldInfoPtr_ONdUFSUycItfOpOkWTvesaAwuVs;

		// Token: 0x04001729 RID: 5929
		private static readonly IntPtr NativeFieldInfoPtr_kEQdqkMxSYRqzzGPHAxtXPlPzkZ;

		// Token: 0x0400172A RID: 5930
		private static readonly IntPtr NativeFieldInfoPtr_WCfDoojgzpSlStzOsMyPeCbQeaJj;

		// Token: 0x0400172B RID: 5931
		private static readonly IntPtr NativeFieldInfoPtr_kQKpjVOkPcBOqzzgUcfedubZWIg;

		// Token: 0x0400172C RID: 5932
		private static readonly IntPtr NativeFieldInfoPtr_lGFnvrVsYXArhmLqurfppgtHXZR;

		// Token: 0x0400172D RID: 5933
		private static readonly IntPtr NativeFieldInfoPtr_FickyNoxMCrkMPcgwygIhassLQk;

		// Token: 0x0400172E RID: 5934
		private static readonly IntPtr NativeFieldInfoPtr_EscSNlnNIwRgGQmzBHNegrWcYDH;

		// Token: 0x0400172F RID: 5935
		private static readonly IntPtr NativeFieldInfoPtr_RTKlxLjGuZLRqfVuXrlNDhwBiTy;

		// Token: 0x04001730 RID: 5936
		private static readonly IntPtr NativeFieldInfoPtr_ippVKLLMqIBFhRtXoenvVQntAJd;

		// Token: 0x04001731 RID: 5937
		private static readonly IntPtr NativeFieldInfoPtr_qjntYfLoESbAWHDBNDGxRCXJMfy;

		// Token: 0x04001732 RID: 5938
		private static readonly IntPtr NativeFieldInfoPtr_XnRnoVdLhJkUOHOAQhipOOfFLpk;

		// Token: 0x04001733 RID: 5939
		private static readonly IntPtr NativeFieldInfoPtr_bUbhTMCGWaCoOqSuDMxcebgtRqzV;

		// Token: 0x04001734 RID: 5940
		private static readonly IntPtr NativeFieldInfoPtr_OLKxRVqOsIErBUQFLStrlOJjitj;

		// Token: 0x04001735 RID: 5941
		private static readonly IntPtr NativeFieldInfoPtr_oHPGAxVesPYWMwkICufJHTEytZG;

		// Token: 0x04001736 RID: 5942
		private static readonly IntPtr NativeFieldInfoPtr_nQtUtyADXujDLjRfcvigVPkcmUX;

		// Token: 0x04001737 RID: 5943
		private static readonly IntPtr NativeFieldInfoPtr_pmmntafFsJVEOxFZPqxaaiZpAMO;

		// Token: 0x04001738 RID: 5944
		private static readonly IntPtr NativeFieldInfoPtr_aOwynHDBqdQEJSMuGFrjRNscfyAD;

		// Token: 0x04001739 RID: 5945
		private static readonly IntPtr NativeFieldInfoPtr_oTQFLvxokTfPetxLSxzfnaixHvs;

		// Token: 0x0400173A RID: 5946
		private static readonly IntPtr NativeFieldInfoPtr_DhbhSRVhmFGIEaEXjUaEnRbxQZd;

		// Token: 0x0400173B RID: 5947
		private static readonly IntPtr NativeFieldInfoPtr_oYSRduOYkhJTOKlJmpGdAomDMXu;

		// Token: 0x0400173C RID: 5948
		private static readonly IntPtr NativeMethodInfoPtr_get_isVibrating_Private_get_Boolean_0;

		// Token: 0x0400173D RID: 5949
		private static readonly IntPtr NativeMethodInfoPtr_get_BatteryLevel_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400173E RID: 5950
		private static readonly IntPtr NativeMethodInfoPtr_get_BatteryCharging_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400173F RID: 5951
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftMotor_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04001740 RID: 5952
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftMotor_Public_Virtual_Final_New_set_Void_Single_0;

		// Token: 0x04001741 RID: 5953
		private static readonly IntPtr NativeMethodInfoPtr_get_RightMotor_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04001742 RID: 5954
		private static readonly IntPtr NativeMethodInfoPtr_set_RightMotor_Public_Virtual_Final_New_set_Void_Single_0;

		// Token: 0x04001743 RID: 5955
		private static readonly IntPtr NativeMethodInfoPtr_get_LightColorR_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04001744 RID: 5956
		private static readonly IntPtr NativeMethodInfoPtr_set_LightColorR_Public_Virtual_Final_New_set_Void_Single_0;

		// Token: 0x04001745 RID: 5957
		private static readonly IntPtr NativeMethodInfoPtr_get_LightColorG_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04001746 RID: 5958
		private static readonly IntPtr NativeMethodInfoPtr_set_LightColorG_Public_Virtual_Final_New_set_Void_Single_0;

		// Token: 0x04001747 RID: 5959
		private static readonly IntPtr NativeMethodInfoPtr_get_LightColorB_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04001748 RID: 5960
		private static readonly IntPtr NativeMethodInfoPtr_set_LightColorB_Public_Virtual_Final_New_set_Void_Single_0;

		// Token: 0x04001749 RID: 5961
		private static readonly IntPtr NativeMethodInfoPtr_get_LightFlashOnDuration_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400174A RID: 5962
		private static readonly IntPtr NativeMethodInfoPtr_set_LightFlashOnDuration_Public_Virtual_Final_New_set_Void_Single_0;

		// Token: 0x0400174B RID: 5963
		private static readonly IntPtr NativeMethodInfoPtr_get_LightFlashOffDuration_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400174C RID: 5964
		private static readonly IntPtr NativeMethodInfoPtr_set_LightFlashOffDuration_Public_Virtual_Final_New_set_Void_Single_0;

		// Token: 0x0400174D RID: 5965
		private static readonly IntPtr NativeMethodInfoPtr_get_microphoneLightMode_Public_Virtual_Final_New_get_DualSenseMicrophoneLightMode_0;

		// Token: 0x0400174E RID: 5966
		private static readonly IntPtr NativeMethodInfoPtr_set_microphoneLightMode_Public_Virtual_Final_New_set_Void_DualSenseMicrophoneLightMode_0;

		// Token: 0x0400174F RID: 5967
		private static readonly IntPtr NativeMethodInfoPtr_get_otherLightBrightness_Public_Virtual_Final_New_get_DualSenseOtherLightBrightness_0;

		// Token: 0x04001750 RID: 5968
		private static readonly IntPtr NativeMethodInfoPtr_set_otherLightBrightness_Public_Virtual_Final_New_set_Void_DualSenseOtherLightBrightness_0;

		// Token: 0x04001751 RID: 5969
		private static readonly IntPtr NativeMethodInfoPtr_get_playerLights_Public_Virtual_Final_New_get_DualSensePlayerLightFlags_0;

		// Token: 0x04001752 RID: 5970
		private static readonly IntPtr NativeMethodInfoPtr_set_playerLights_Public_Virtual_Final_New_set_Void_DualSensePlayerLightFlags_0;

		// Token: 0x04001753 RID: 5971
		private static readonly IntPtr NativeMethodInfoPtr_get_AccelerometerValue_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x04001754 RID: 5972
		private static readonly IntPtr NativeMethodInfoPtr_get_AccelerometerValueRaw_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x04001755 RID: 5973
		private static readonly IntPtr NativeMethodInfoPtr_get_GyroscopeValue_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x04001756 RID: 5974
		private static readonly IntPtr NativeMethodInfoPtr_get_GyroscopeValueRaw_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x04001757 RID: 5975
		private static readonly IntPtr NativeMethodInfoPtr_get_LastGyroscopeValue_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x04001758 RID: 5976
		private static readonly IntPtr NativeMethodInfoPtr_get_LastGyroscopeValueRaw_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x04001759 RID: 5977
		private static readonly IntPtr NativeMethodInfoPtr_get_Orientation_Public_Virtual_Final_New_get_Quaternion_0;

		// Token: 0x0400175A RID: 5978
		private static readonly IntPtr NativeMethodInfoPtr_ResetOrientation_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400175B RID: 5979
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxTouches_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400175C RID: 5980
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchCount_Public_Virtual_Final_New_Int32_0;

		// Token: 0x0400175D RID: 5981
		private static readonly IntPtr NativeMethodInfoPtr_IsTouchingAtIndex_Public_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x0400175E RID: 5982
		private static readonly IntPtr NativeMethodInfoPtr_IsTouchingAtTouchId_Public_Virtual_Final_New_Boolean_Int32_0;

		// Token: 0x0400175F RID: 5983
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchIdAtIndex_Public_Virtual_Final_New_Int32_Int32_0;

		// Token: 0x04001760 RID: 5984
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionByIndex_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0;

		// Token: 0x04001761 RID: 5985
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Vector2_0;

		// Token: 0x04001762 RID: 5986
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionAbsoluteByIndex_Public_Virtual_Final_New_Boolean_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x04001763 RID: 5987
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPositionAbsoluteByTouchId_Public_Virtual_Final_New_Boolean_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x04001764 RID: 5988
		private static readonly IntPtr NativeMethodInfoPtr_StopLightFlash_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001765 RID: 5989
		private static readonly IntPtr NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001766 RID: 5990
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InitArgs_0;

		// Token: 0x04001767 RID: 5991
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_UpdateLoopType_0;

		// Token: 0x04001768 RID: 5992
		private static readonly IntPtr NativeMethodInfoPtr_ParseInputReport_Public_Virtual_Boolean_IntPtr_Int32_Double_0;

		// Token: 0x04001769 RID: 5993
		private static readonly IntPtr NativeMethodInfoPtr_CreateControllerExtension_Public_Virtual_Extension_0;

		// Token: 0x0400176A RID: 5994
		private static readonly IntPtr NativeMethodInfoPtr_TSrVJoovajrfJhhpgPSTUJfwLdn_Private_Void_rBapAxSjeCWOiOHyzennMIRNCHfj_0;

		// Token: 0x0400176B RID: 5995
		private static readonly IntPtr NativeMethodInfoPtr_zNXomrMcpdzggtTitEdjWdzqgEbj_Private_Boolean_rBapAxSjeCWOiOHyzennMIRNCHfj_0;

		// Token: 0x0400176C RID: 5996
		private static readonly IntPtr NativeMethodInfoPtr_IuZFpZfntxLYutBfTAuqVYKxfjj_Private_Void_0;

		// Token: 0x0400176D RID: 5997
		private static readonly IntPtr NativeMethodInfoPtr_IuZFpZfntxLYutBfTAuqVYKxfjj_Private_Void_NativeBuffer_Int32_0;

		// Token: 0x0400176E RID: 5998
		private static readonly IntPtr NativeMethodInfoPtr_bWlObuwhPuWKIEdjMaLCkLFuAubl_Private_Boolean_rBapAxSjeCWOiOHyzennMIRNCHfj_0;

		// Token: 0x0400176F RID: 5999
		private static readonly IntPtr NativeMethodInfoPtr_QLZdJmwnUkddZisUnLmixtMACSh_Private_Void_NativeBuffer_Double_0;

		// Token: 0x04001770 RID: 6000
		private static readonly IntPtr NativeMethodInfoPtr_gbHdOZilzwmhPaLsoSTdCfNBZKKu_Private_Void_Il2CppReferenceArray_1_HIDControllerElement_NativeBuffer_Double_0;

		// Token: 0x04001771 RID: 6001
		private static readonly IntPtr NativeMethodInfoPtr_KHqFCPtEwwtfLgFTiAQgQrcOjjb_Private_Void_0;

		// Token: 0x04001772 RID: 6002
		private static readonly IntPtr NativeMethodInfoPtr_LeplGUzBFQKWBFpGxiDontkepOK_Private_Void_NativeBuffer_0;

		// Token: 0x04001773 RID: 6003
		private static readonly IntPtr NativeMethodInfoPtr_TLwGAPVnufqvIFbiUtPrqoyNGkr_Private_Void_0;

		// Token: 0x04001774 RID: 6004
		private static readonly IntPtr NativeMethodInfoPtr_cohbXzjxzOcNAeSeyhxjbfXCJFQ_Private_Static_Boolean_byref_Vector3_0;

		// Token: 0x04001775 RID: 6005
		private static readonly IntPtr NativeMethodInfoPtr_OeYAIeGFRPZFIOSRbUgsokmVUlq_Private_Void_Vector3_Vector3_0;

		// Token: 0x04001776 RID: 6006
		private static readonly IntPtr NativeMethodInfoPtr_vZfQKBwCEWApahARXbtasPYbHzZ_Private_Static_Quaternion_Quaternion_Vector3_0;

		// Token: 0x04001777 RID: 6007
		private static readonly IntPtr NativeMethodInfoPtr_HNzAAnmQWRfPwDoAHmOVRTmQhjHg_Private_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x04001778 RID: 6008
		private static readonly IntPtr NativeMethodInfoPtr_thTaDDdinQFebglkGeuCSsdQcuKj_Private_Quaternion_Quaternion_pDwfbxnaRgNWVWTVBoPzQJoWExW_0;

		// Token: 0x04001779 RID: 6009
		private static readonly IntPtr NativeMethodInfoPtr_Inverse_Public_Static_Quaternion_Quaternion_0;

		// Token: 0x0400177A RID: 6010
		private static readonly IntPtr NativeMethodInfoPtr_TLAawbbzgTTOntVMVRSOYGgBlSz_Private_Single_Single_Single_0;

		// Token: 0x0400177B RID: 6011
		private static readonly IntPtr NativeMethodInfoPtr_TgJSJBfkacluENeCrcEMrjyCzZk_Private_Vector3_Vector3_Single_0;

		// Token: 0x0400177C RID: 6012
		private static readonly IntPtr NativeMethodInfoPtr_EVPzweUACCpCpHpeeEMnGnyiGub_Private_Quaternion_Vector3_Single_0;

		// Token: 0x0400177D RID: 6013
		private static readonly IntPtr NativeMethodInfoPtr_FTcGFQGKepOCGivEwiXcIfpiwzo_Private_Quaternion_Vector3_Single_0;

		// Token: 0x0400177E RID: 6014
		private static readonly IntPtr NativeMethodInfoPtr_fQsbUcErhAOleloWxhSUBrwCiPqT_Private_Single_Vector3_0;

		// Token: 0x0400177F RID: 6015
		private static readonly IntPtr NativeMethodInfoPtr_ekTnVhTROxwNIqHvokaYcuOYwut_Private_Boolean_Single_0;

		// Token: 0x04001780 RID: 6016
		private static readonly IntPtr NativeMethodInfoPtr_robusEWPfTfHCeHSBdccMSzDezZ_Private_Boolean_Vector3_byref_hcFgwcIDMlBhmOMlfSjUYrwdSdO_0;

		// Token: 0x04001781 RID: 6017
		private static readonly IntPtr NativeMethodInfoPtr_DIkDxlDsItuOVMlNgZuHlQvMhaFQ_Private_Boolean_Vector3_0;

		// Token: 0x04001782 RID: 6018
		private static readonly IntPtr NativeMethodInfoPtr_uaWAYcACiSsMWDcNpMnjBRRdSgR_Private_Boolean_Vector3_0;

		// Token: 0x04001783 RID: 6019
		private static readonly IntPtr NativeMethodInfoPtr_DtptwGvMHHWYtiObmjGUBSGKWWS_Private_Vector3_Il2CppStructArray_1_Single_0;

		// Token: 0x04001784 RID: 6020
		private static readonly IntPtr NativeMethodInfoPtr_ThbIRbwHDVgOvNnDNaPNIFyStTC_Private_Vector3_ExpandableArray_DataContainer_1_vwnDNljqUPuTIauvXLOcbBHPCtP_0;

		// Token: 0x04001785 RID: 6021
		private static readonly IntPtr NativeMethodInfoPtr_ThbIRbwHDVgOvNnDNaPNIFyStTC_Private_Vector3_Vector3_Single_0;

		// Token: 0x04001786 RID: 6022
		private static readonly IntPtr NativeMethodInfoPtr_jouvWBjeMlbfGjdhJNLFnQsLdBOb_Private_Int32_Int32_0;

		// Token: 0x04001787 RID: 6023
		private static readonly IntPtr NativeMethodInfoPtr_prYGimAxzhhkgHXVHtncfHnGFYY_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Single_0;

		// Token: 0x04001788 RID: 6024
		private static readonly IntPtr NativeMethodInfoPtr_qeFMJjnMLTATARRnrcCxoPuiWfW_Private_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Single_0;

		// Token: 0x04001789 RID: 6025
		private static readonly IntPtr NativeMethodInfoPtr_nQkXLniZUrHBOFIEofKzaOcIykH_Private_Single_0;

		// Token: 0x0400178A RID: 6026
		private static readonly IntPtr NativeMethodInfoPtr_sDEBJHxzkRveoJulMncayCApMQt_Private_Void_NativeBuffer_Il2CppStructArray_1_TouchData_0;

		// Token: 0x0400178B RID: 6027
		private static readonly IntPtr NativeMethodInfoPtr_okliethpUEesGZsNxgsPNrXkCiZ_Private_Int32_Int32_Boolean_Int32_0;

		// Token: 0x0400178C RID: 6028
		private static readonly IntPtr NativeMethodInfoPtr_dGrqytUXXWkxJliqQJXVhZPBxBd_Private_Void_0;

		// Token: 0x0400178D RID: 6029
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400178E RID: 6030
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x0400178F RID: 6031
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_Static_Boolean_Int32_Int32_0;

		// Token: 0x04001790 RID: 6032
		private static readonly IntPtr NativeMethodInfoPtr_QPTYfSspdaYTKmpyYDTIDnYwATk_Private_Static_UInt32_NativeBuffer_Int32_0;

		// Token: 0x04001791 RID: 6033
		private static readonly IntPtr NativeMethodInfoPtr_tTNzTwfCMQfwvWqHsIiWcwmruoU_Private_Static_uASSUXqpRKvdvBmSBaslDYQnViNe_DualSenseOtherLightBrightness_0;

		// Token: 0x04001792 RID: 6034
		private static readonly IntPtr NativeMethodInfoPtr_ycNGLfgdPFBcicRXNFIZGfRisvEb_Private_Static_DualSenseOtherLightBrightness_uASSUXqpRKvdvBmSBaslDYQnViNe_0;

		// Token: 0x0200032C RID: 812
		[OriginalName("Rewired_Core.dll", "", "pDwfbxnaRgNWVWTVBoPzQJoWExW")]
		public enum pDwfbxnaRgNWVWTVBoPzQJoWExW
		{
			// Token: 0x040038B3 RID: 14515
			QFCZGlfZVeiVmaDBRgNsKFqbawas,
			// Token: 0x040038B4 RID: 14516
			eDYTIcIkzAWXVvGzVfexWBhpAnL,
			// Token: 0x040038B5 RID: 14517
			sPWfPaEuGSIDnmqEualXByKukuvB
		}

		// Token: 0x0200032D RID: 813
		[OriginalName("Rewired_Core.dll", "", "hcFgwcIDMlBhmOMlfSjUYrwdSdO")]
		public enum hcFgwcIDMlBhmOMlfSjUYrwdSdO
		{
			// Token: 0x040038B7 RID: 14519
			urhBwQidoSAKHIhcxeCWNbALMhkh,
			// Token: 0x040038B8 RID: 14520
			WwnbAovhLwkRABETTocRgkxcAOjg,
			// Token: 0x040038B9 RID: 14521
			eDYTIcIkzAWXVvGzVfexWBhpAnL
		}

		// Token: 0x0200032E RID: 814
		[OriginalName("Rewired_Core.dll", "", "uASSUXqpRKvdvBmSBaslDYQnViNe")]
		public enum uASSUXqpRKvdvBmSBaslDYQnViNe : byte
		{
			// Token: 0x040038BB RID: 14523
			pNSMxMXDycGFQgJxLApiBPvHrZHJ,
			// Token: 0x040038BC RID: 14524
			LInudqRLmpCvzGvPWRzXXvckjMM,
			// Token: 0x040038BD RID: 14525
			VcoRsyMgfKBIyUuojdngCLrdYien
		}
	}
}
