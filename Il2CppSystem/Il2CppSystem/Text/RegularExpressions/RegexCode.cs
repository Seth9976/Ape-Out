using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000053 RID: 83
	public sealed class RegexCode : Object
	{
		// Token: 0x06000530 RID: 1328 RVA: 0x00024D08 File Offset: 0x00022F08
		// Note: this type is marked as 'beforefieldinit'.
		static RegexCode()
		{
			Il2CppClassPointerStore<RegexCode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexCode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexCode>.NativeClassPtr);
			RegexCode.NativeFieldInfoPtr__codes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "_codes");
			RegexCode.NativeFieldInfoPtr__strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "_strings");
			RegexCode.NativeFieldInfoPtr__trackcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "_trackcount");
			RegexCode.NativeFieldInfoPtr__caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "_caps");
			RegexCode.NativeFieldInfoPtr__capsize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "_capsize");
			RegexCode.NativeFieldInfoPtr__fcPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "_fcPrefix");
			RegexCode.NativeFieldInfoPtr__bmPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "_bmPrefix");
			RegexCode.NativeFieldInfoPtr__anchors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "_anchors");
			RegexCode.NativeFieldInfoPtr__rightToLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "_rightToLeft");
			RegexCode.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Int32_List_1_String_Int32_Hashtable_Int32_RegexBoyerMoore_RegexPrefix_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, 100664125);
			RegexCode.NativeMethodInfoPtr_OpcodeBacktracks_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, 100664126);
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00024E14 File Offset: 0x00023014
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 370414, RefRangeEnd = 370415, XrefRangeStart = 370407, XrefRangeEnd = 370414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexCode(Il2CppStructArray<int> codes, List<string> stringlist, int trackcount, Hashtable caps, int capsize, RegexBoyerMoore bmPrefix, RegexPrefix fcPrefix, int anchors, bool rightToLeft)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexCode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(codes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stringlist);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackcount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caps);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capsize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bmPrefix);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fcPrefix);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchors;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightToLeft;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCode.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Int32_List_1_String_Int32_Hashtable_Int32_RegexBoyerMoore_RegexPrefix_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00024EE4 File Offset: 0x000230E4
		[CallerCount(0)]
		public unsafe static bool OpcodeBacktracks(int Op)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCode.NativeMethodInfoPtr_OpcodeBacktracks_Internal_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00003E79 File Offset: 0x00002079
		public RegexCode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x00024F24 File Offset: 0x00023124
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x00003E82 File Offset: 0x00002082
		public unsafe Il2CppStructArray<int> _codes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__codes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__codes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x00024F54 File Offset: 0x00023154
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x00003EA1 File Offset: 0x000020A1
		public unsafe Il2CppStringArray _strings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__strings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__strings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x00024F84 File Offset: 0x00023184
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x00003EC0 File Offset: 0x000020C0
		public unsafe int _trackcount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__trackcount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__trackcount)) = value;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x00024FAC File Offset: 0x000231AC
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x00003EDB File Offset: 0x000020DB
		public unsafe Hashtable _caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x00024FDC File Offset: 0x000231DC
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x00003EFA File Offset: 0x000020FA
		public unsafe int _capsize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__capsize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__capsize)) = value;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x00025004 File Offset: 0x00023204
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x00003F15 File Offset: 0x00002115
		public unsafe RegexPrefix _fcPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__fcPrefix);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexPrefix>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__fcPrefix), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x00025034 File Offset: 0x00023234
		// (set) Token: 0x06000541 RID: 1345 RVA: 0x00003F34 File Offset: 0x00002134
		public unsafe RegexBoyerMoore _bmPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__bmPrefix);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexBoyerMoore>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__bmPrefix), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x00025064 File Offset: 0x00023264
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x00003F53 File Offset: 0x00002153
		public unsafe int _anchors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__anchors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__anchors)) = value;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x0002508C File Offset: 0x0002328C
		// (set) Token: 0x06000545 RID: 1349 RVA: 0x00003F6E File Offset: 0x0000216E
		public unsafe bool _rightToLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__rightToLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__rightToLeft)) = value;
			}
		}

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeFieldInfoPtr__codes;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeFieldInfoPtr__strings;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeFieldInfoPtr__trackcount;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeFieldInfoPtr__caps;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeFieldInfoPtr__capsize;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeFieldInfoPtr__fcPrefix;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeFieldInfoPtr__bmPrefix;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeFieldInfoPtr__anchors;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeFieldInfoPtr__rightToLeft;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Int32_List_1_String_Int32_Hashtable_Int32_RegexBoyerMoore_RegexPrefix_Int32_Boolean_0;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeMethodInfoPtr_OpcodeBacktracks_Internal_Static_Boolean_Int32_0;
	}
}
