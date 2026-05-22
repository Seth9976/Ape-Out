using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppRewired.Internal
{
	// Token: 0x02000037 RID: 55
	public class GUIText : MonoBehaviour
	{
		// Token: 0x06000410 RID: 1040 RVA: 0x0003D4BC File Offset: 0x0003B6BC
		// Note: this type is marked as 'beforefieldinit'.
		static GUIText()
		{
			Il2CppClassPointerStore<GUIText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Internal", "GUIText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIText>.NativeClassPtr);
			GUIText.NativeFieldInfoPtr_doMAsxHbcfFUrRtVqDzQEGdeJnLw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIText>.NativeClassPtr, "doMAsxHbcfFUrRtVqDzQEGdeJnLw");
			GUIText.NativeFieldInfoPtr_STcgKqMhkSvcsrRZXkkPTVbtRAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIText>.NativeClassPtr, "STcgKqMhkSvcsrRZXkkPTVbtRAL");
			GUIText.NativeFieldInfoPtr_mbhfeHawyJaiEoDhIaIGYioExdbo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIText>.NativeClassPtr, "mbhfeHawyJaiEoDhIaIGYioExdbo");
			GUIText.NativeFieldInfoPtr_xeuPGzGLWpbrMtJiEHPhOGTgmn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIText>.NativeClassPtr, "xeuPGzGLWpbrMtJiEHPhOGTgmn");
			GUIText.NativeFieldInfoPtr_fjIOtMrCnueQEGpNBNGmirWltGV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIText>.NativeClassPtr, "fjIOtMrCnueQEGpNBNGmirWltGV");
			GUIText.NativeFieldInfoPtr_zQsFzBqaXmFZkPMjNudcAeyCMJs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIText>.NativeClassPtr, "zQsFzBqaXmFZkPMjNudcAeyCMJs");
			GUIText.NativeFieldInfoPtr_RGvCtYdZWdDtvEknygJzYowCOkZC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIText>.NativeClassPtr, "RGvCtYdZWdDtvEknygJzYowCOkZC");
			GUIText.NativeFieldInfoPtr_VtRhouccooCLIahlmNabkBDPRYi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIText>.NativeClassPtr, "VtRhouccooCLIahlmNabkBDPRYi");
			GUIText.NativeFieldInfoPtr_XivGFRyHLRFFxfezobNuIINjrTlU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIText>.NativeClassPtr, "XivGFRyHLRFFxfezobNuIINjrTlU");
			GUIText.NativeFieldInfoPtr__pixelOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIText>.NativeClassPtr, "_pixelOffset");
			GUIText.NativeFieldInfoPtr__useUnityUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIText>.NativeClassPtr, "_useUnityUI");
			GUIText.NativeFieldInfoPtr_RzqejbgaytAQRgGTCWBelYRHJEBz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIText>.NativeClassPtr, "RzqejbgaytAQRgGTCWBelYRHJEBz");
			GUIText.NativeFieldInfoPtr_oCYukaHdxNaTgAcWEOKeKuoWdcek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIText>.NativeClassPtr, "oCYukaHdxNaTgAcWEOKeKuoWdcek");
			GUIText.NativeFieldInfoPtr_oAzvixdYHfTtZNlGvnJrhzZGENc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIText>.NativeClassPtr, "oAzvixdYHfTtZNlGvnJrhzZGENc");
			GUIText.NativeFieldInfoPtr_IfFqGrbCjOOWxAUSHHxmZjONozG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIText>.NativeClassPtr, "IfFqGrbCjOOWxAUSHHxmZjONozG");
			GUIText.NativeFieldInfoPtr_UhLDkJGDCrHizWhnJQVEMHyHhbJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIText>.NativeClassPtr, "UhLDkJGDCrHizWhnJQVEMHyHhbJ");
			GUIText.NativeFieldInfoPtr_QfrBfSWJlVJqHhrqUlJGvCXPVFl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIText>.NativeClassPtr, "QfrBfSWJlVJqHhrqUlJGvCXPVFl");
			GUIText.NativeFieldInfoPtr_YyHZsHgUpubOpsxWqszEcCxlbjZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIText>.NativeClassPtr, "YyHZsHgUpubOpsxWqszEcCxlbjZ");
			GUIText.NativeFieldInfoPtr_uHdPYIBIgpFdRWXNdCxOXcwbKd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIText>.NativeClassPtr, "uHdPYIBIgpFdRWXNdCxOXcwbKd");
			GUIText.NativeFieldInfoPtr_iVSfXwfRDMRwpSfMhYzAkRCZubU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIText>.NativeClassPtr, "iVSfXwfRDMRwpSfMhYzAkRCZubU");
			GUIText.NativeFieldInfoPtr_VMmRDxhNSPbrsfKODOcAglexlrh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIText>.NativeClassPtr, "VMmRDxhNSPbrsfKODOcAglexlrh");
			GUIText.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100663991);
			GUIText.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100663992);
			GUIText.NativeMethodInfoPtr_get_anchor_Public_get_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100663993);
			GUIText.NativeMethodInfoPtr_set_anchor_Public_set_Void_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100663994);
			GUIText.NativeMethodInfoPtr_get_alignment_Public_get_TextAlignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100663995);
			GUIText.NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAlignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100663996);
			GUIText.NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100663997);
			GUIText.NativeMethodInfoPtr_set_lineSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100663998);
			GUIText.NativeMethodInfoPtr_get_font_Public_get_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100663999);
			GUIText.NativeMethodInfoPtr_set_font_Public_set_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100664000);
			GUIText.NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100664001);
			GUIText.NativeMethodInfoPtr_set_fontSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100664002);
			GUIText.NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100664003);
			GUIText.NativeMethodInfoPtr_set_fontStyle_Public_set_Void_FontStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100664004);
			GUIText.NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100664005);
			GUIText.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100664006);
			GUIText.NativeMethodInfoPtr_get_pixelOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100664007);
			GUIText.NativeMethodInfoPtr_set_pixelOffset_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100664008);
			GUIText.NativeMethodInfoPtr_get_useUnityUI_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100664009);
			GUIText.NativeMethodInfoPtr_set_useUnityUI_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100664010);
			GUIText.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100664011);
			GUIText.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100664012);
			GUIText.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100664013);
			GUIText.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100664014);
			GUIText.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100664015);
			GUIText.NativeMethodInfoPtr_NZidsYjwUayJneQBUlaDXuOijia_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100664016);
			GUIText.NativeMethodInfoPtr_WISAechUtaHgbZBBPcmqFTRyAIDh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100664017);
			GUIText.NativeMethodInfoPtr_ikZIHBmOOnjfqEhVcomzQgxDeis_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100664018);
			GUIText.NativeMethodInfoPtr_GetOrAddComponent_Internal_Static_GUIText_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100664019);
			GUIText.NativeMethodInfoPtr_CreateLogger_Internal_Static_GUIText_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100664020);
			GUIText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIText>.NativeClassPtr, 100664021);
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x0003D8FC File Offset: 0x0003BAFC
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x0003D934 File Offset: 0x0003BB34
		public unsafe string text
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0003D978 File Offset: 0x0003BB78
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x0003D9B4 File Offset: 0x0003BBB4
		public unsafe TextAnchor anchor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_get_anchor_Public_get_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 245032, RefRangeEnd = 245034, XrefRangeStart = 245030, XrefRangeEnd = 245032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_set_anchor_Public_set_Void_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x0003D9F4 File Offset: 0x0003BBF4
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x0003DA30 File Offset: 0x0003BC30
		public unsafe TextAlignment alignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_get_alignment_Public_get_TextAlignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAlignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x0003DA70 File Offset: 0x0003BC70
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x0003DAAC File Offset: 0x0003BCAC
		public unsafe float lineSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_set_lineSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x0003DAEC File Offset: 0x0003BCEC
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x0003DB2C File Offset: 0x0003BD2C
		public unsafe Font font
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_get_font_Public_get_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Font>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245034, XrefRangeEnd = 245036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_set_font_Public_set_Void_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x0003DB70 File Offset: 0x0003BD70
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x0003DBAC File Offset: 0x0003BDAC
		public unsafe int fontSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245036, XrefRangeEnd = 245038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_set_fontSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x0003DBEC File Offset: 0x0003BDEC
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x0003DC28 File Offset: 0x0003BE28
		public unsafe FontStyle fontStyle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245038, XrefRangeEnd = 245040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_set_fontStyle_Public_set_Void_FontStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x0003DC68 File Offset: 0x0003BE68
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x0003DCA4 File Offset: 0x0003BEA4
		public unsafe Color color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245040, XrefRangeEnd = 245043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x0003DCE4 File Offset: 0x0003BEE4
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x0003DD20 File Offset: 0x0003BF20
		public unsafe Vector2 pixelOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_get_pixelOffset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_set_pixelOffset_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x0003DD60 File Offset: 0x0003BF60
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x0003DD9C File Offset: 0x0003BF9C
		public unsafe bool useUnityUI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_get_useUnityUI_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245043, XrefRangeEnd = 245045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_set_useUnityUI_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0003DDDC File Offset: 0x0003BFDC
		[CallerCount(0)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0003DE10 File Offset: 0x0003C010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245045, XrefRangeEnd = 245046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0003DE44 File Offset: 0x0003C044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245046, XrefRangeEnd = 245076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0003DE78 File Offset: 0x0003C078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245076, XrefRangeEnd = 245096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0003DEAC File Offset: 0x0003C0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245096, XrefRangeEnd = 245097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0003DEE0 File Offset: 0x0003C0E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 245228, RefRangeEnd = 245231, XrefRangeStart = 245097, XrefRangeEnd = 245228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NZidsYjwUayJneQBUlaDXuOijia()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_NZidsYjwUayJneQBUlaDXuOijia_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0003DF14 File Offset: 0x0003C114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245247, RefRangeEnd = 245248, XrefRangeStart = 245231, XrefRangeEnd = 245247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WISAechUtaHgbZBBPcmqFTRyAIDh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_WISAechUtaHgbZBBPcmqFTRyAIDh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0003DF48 File Offset: 0x0003C148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245279, RefRangeEnd = 245280, XrefRangeStart = 245248, XrefRangeEnd = 245279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ikZIHBmOOnjfqEhVcomzQgxDeis()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_ikZIHBmOOnjfqEhVcomzQgxDeis_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0003DF7C File Offset: 0x0003C17C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245309, RefRangeEnd = 245310, XrefRangeStart = 245280, XrefRangeEnd = 245309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUIText GetOrAddComponent(GameObject gameObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_GetOrAddComponent_Internal_Static_GUIText_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIText>(intPtr3) : null;
			}
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0003DFC0 File Offset: 0x0003C1C0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 245324, RefRangeEnd = 245329, XrefRangeStart = 245310, XrefRangeEnd = 245324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUIText CreateLogger(GameObject gameObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr_CreateLogger_Internal_Static_GUIText_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIText>(intPtr3) : null;
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0003E004 File Offset: 0x0003C204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245329, XrefRangeEnd = 245332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIText()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIText>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0000343D File Offset: 0x0000163D
		public GUIText(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x0003E040 File Offset: 0x0003C240
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x00003446 File Offset: 0x00001646
		public unsafe string doMAsxHbcfFUrRtVqDzQEGdeJnLw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_doMAsxHbcfFUrRtVqDzQEGdeJnLw);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_doMAsxHbcfFUrRtVqDzQEGdeJnLw), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x0003E068 File Offset: 0x0003C268
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x00003465 File Offset: 0x00001665
		public unsafe GUIStyle STcgKqMhkSvcsrRZXkkPTVbtRAL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_STcgKqMhkSvcsrRZXkkPTVbtRAL);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_STcgKqMhkSvcsrRZXkkPTVbtRAL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x0003E098 File Offset: 0x0003C298
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x00003484 File Offset: 0x00001684
		public unsafe TextAnchor mbhfeHawyJaiEoDhIaIGYioExdbo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_mbhfeHawyJaiEoDhIaIGYioExdbo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_mbhfeHawyJaiEoDhIaIGYioExdbo)) = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x0003E0C0 File Offset: 0x0003C2C0
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x0000349F File Offset: 0x0000169F
		public unsafe TextAlignment xeuPGzGLWpbrMtJiEHPhOGTgmn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_xeuPGzGLWpbrMtJiEHPhOGTgmn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_xeuPGzGLWpbrMtJiEHPhOGTgmn)) = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x0003E0E8 File Offset: 0x0003C2E8
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x000034BA File Offset: 0x000016BA
		public unsafe float fjIOtMrCnueQEGpNBNGmirWltGV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_fjIOtMrCnueQEGpNBNGmirWltGV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_fjIOtMrCnueQEGpNBNGmirWltGV)) = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x0003E110 File Offset: 0x0003C310
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x000034D5 File Offset: 0x000016D5
		public unsafe Font zQsFzBqaXmFZkPMjNudcAeyCMJs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_zQsFzBqaXmFZkPMjNudcAeyCMJs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_zQsFzBqaXmFZkPMjNudcAeyCMJs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x0003E140 File Offset: 0x0003C340
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x000034F4 File Offset: 0x000016F4
		public unsafe int RGvCtYdZWdDtvEknygJzYowCOkZC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_RGvCtYdZWdDtvEknygJzYowCOkZC);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_RGvCtYdZWdDtvEknygJzYowCOkZC)) = value;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x0003E168 File Offset: 0x0003C368
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x0000350F File Offset: 0x0000170F
		public unsafe FontStyle VtRhouccooCLIahlmNabkBDPRYi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_VtRhouccooCLIahlmNabkBDPRYi);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_VtRhouccooCLIahlmNabkBDPRYi)) = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x0003E190 File Offset: 0x0003C390
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x0000352A File Offset: 0x0000172A
		public unsafe Color XivGFRyHLRFFxfezobNuIINjrTlU
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_XivGFRyHLRFFxfezobNuIINjrTlU);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_XivGFRyHLRFFxfezobNuIINjrTlU)) = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x0003E1B8 File Offset: 0x0003C3B8
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x00003545 File Offset: 0x00001745
		public unsafe Vector2 _pixelOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr__pixelOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr__pixelOffset)) = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x0003E1E0 File Offset: 0x0003C3E0
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x00003560 File Offset: 0x00001760
		public unsafe bool _useUnityUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr__useUnityUI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr__useUnityUI)) = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x0003E208 File Offset: 0x0003C408
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x0000357B File Offset: 0x0000177B
		public unsafe bool RzqejbgaytAQRgGTCWBelYRHJEBz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_RzqejbgaytAQRgGTCWBelYRHJEBz);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_RzqejbgaytAQRgGTCWBelYRHJEBz)) = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x0003E230 File Offset: 0x0003C430
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x00003596 File Offset: 0x00001796
		public unsafe bool oCYukaHdxNaTgAcWEOKeKuoWdcek
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_oCYukaHdxNaTgAcWEOKeKuoWdcek);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_oCYukaHdxNaTgAcWEOKeKuoWdcek)) = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0003E258 File Offset: 0x0003C458
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x000035B1 File Offset: 0x000017B1
		public unsafe bool oAzvixdYHfTtZNlGvnJrhzZGENc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_oAzvixdYHfTtZNlGvnJrhzZGENc);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_oAzvixdYHfTtZNlGvnJrhzZGENc)) = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x0003E280 File Offset: 0x0003C480
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x000035CC File Offset: 0x000017CC
		public unsafe bool IfFqGrbCjOOWxAUSHHxmZjONozG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_IfFqGrbCjOOWxAUSHHxmZjONozG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_IfFqGrbCjOOWxAUSHHxmZjONozG)) = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x0003E2A8 File Offset: 0x0003C4A8
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x000035E7 File Offset: 0x000017E7
		public unsafe bool UhLDkJGDCrHizWhnJQVEMHyHhbJ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_UhLDkJGDCrHizWhnJQVEMHyHhbJ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_UhLDkJGDCrHizWhnJQVEMHyHhbJ)) = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x0003E2D0 File Offset: 0x0003C4D0
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x00003602 File Offset: 0x00001802
		public unsafe bool QfrBfSWJlVJqHhrqUlJGvCXPVFl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_QfrBfSWJlVJqHhrqUlJGvCXPVFl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_QfrBfSWJlVJqHhrqUlJGvCXPVFl)) = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x0003E2F8 File Offset: 0x0003C4F8
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x0000361D File Offset: 0x0000181D
		public unsafe bool YyHZsHgUpubOpsxWqszEcCxlbjZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_YyHZsHgUpubOpsxWqszEcCxlbjZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_YyHZsHgUpubOpsxWqszEcCxlbjZ)) = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x0003E320 File Offset: 0x0003C520
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x00003638 File Offset: 0x00001838
		public unsafe Text uHdPYIBIgpFdRWXNdCxOXcwbKd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_uHdPYIBIgpFdRWXNdCxOXcwbKd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_uHdPYIBIgpFdRWXNdCxOXcwbKd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x0003E350 File Offset: 0x0003C550
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x00003657 File Offset: 0x00001857
		public unsafe bool iVSfXwfRDMRwpSfMhYzAkRCZubU
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_iVSfXwfRDMRwpSfMhYzAkRCZubU);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_iVSfXwfRDMRwpSfMhYzAkRCZubU)) = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0003E378 File Offset: 0x0003C578
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x00003672 File Offset: 0x00001872
		public unsafe bool VMmRDxhNSPbrsfKODOcAglexlrh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_VMmRDxhNSPbrsfKODOcAglexlrh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIText.NativeFieldInfoPtr_VMmRDxhNSPbrsfKODOcAglexlrh)) = value;
			}
		}

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeFieldInfoPtr_doMAsxHbcfFUrRtVqDzQEGdeJnLw;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeFieldInfoPtr_STcgKqMhkSvcsrRZXkkPTVbtRAL;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeFieldInfoPtr_mbhfeHawyJaiEoDhIaIGYioExdbo;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeFieldInfoPtr_xeuPGzGLWpbrMtJiEHPhOGTgmn;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeFieldInfoPtr_fjIOtMrCnueQEGpNBNGmirWltGV;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeFieldInfoPtr_zQsFzBqaXmFZkPMjNudcAeyCMJs;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeFieldInfoPtr_RGvCtYdZWdDtvEknygJzYowCOkZC;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeFieldInfoPtr_VtRhouccooCLIahlmNabkBDPRYi;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeFieldInfoPtr_XivGFRyHLRFFxfezobNuIINjrTlU;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeFieldInfoPtr__pixelOffset;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeFieldInfoPtr__useUnityUI;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeFieldInfoPtr_RzqejbgaytAQRgGTCWBelYRHJEBz;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeFieldInfoPtr_oCYukaHdxNaTgAcWEOKeKuoWdcek;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeFieldInfoPtr_oAzvixdYHfTtZNlGvnJrhzZGENc;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeFieldInfoPtr_IfFqGrbCjOOWxAUSHHxmZjONozG;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeFieldInfoPtr_UhLDkJGDCrHizWhnJQVEMHyHhbJ;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeFieldInfoPtr_QfrBfSWJlVJqHhrqUlJGvCXPVFl;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeFieldInfoPtr_YyHZsHgUpubOpsxWqszEcCxlbjZ;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeFieldInfoPtr_uHdPYIBIgpFdRWXNdCxOXcwbKd;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeFieldInfoPtr_iVSfXwfRDMRwpSfMhYzAkRCZubU;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeFieldInfoPtr_VMmRDxhNSPbrsfKODOcAglexlrh;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr_get_anchor_Public_get_TextAnchor_0;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeMethodInfoPtr_set_anchor_Public_set_Void_TextAnchor_0;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeMethodInfoPtr_get_alignment_Public_get_TextAlignment_0;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAlignment_0;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeMethodInfoPtr_set_lineSpacing_Public_set_Void_Single_0;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeMethodInfoPtr_get_font_Public_get_Font_0;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeMethodInfoPtr_set_font_Public_set_Void_Font_0;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr_set_fontSize_Public_set_Void_Int32_0;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyle_0;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeMethodInfoPtr_set_fontStyle_Public_set_Void_FontStyle_0;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_set_Void_Color_0;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelOffset_Public_get_Vector2_0;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr_set_pixelOffset_Public_set_Void_Vector2_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_get_useUnityUI_Public_get_Boolean_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr_set_useUnityUI_Public_set_Void_Boolean_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr_NZidsYjwUayJneQBUlaDXuOijia_Private_Void_0;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr_WISAechUtaHgbZBBPcmqFTRyAIDh_Private_Void_0;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr_ikZIHBmOOnjfqEhVcomzQgxDeis_Private_Void_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr_GetOrAddComponent_Internal_Static_GUIText_GameObject_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_CreateLogger_Internal_Static_GUIText_GameObject_0;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
