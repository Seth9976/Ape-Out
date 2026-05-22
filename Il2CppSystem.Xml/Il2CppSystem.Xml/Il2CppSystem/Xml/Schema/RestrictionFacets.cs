using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200011F RID: 287
	public class RestrictionFacets : Object
	{
		// Token: 0x060016F2 RID: 5874 RVA: 0x000749BC File Offset: 0x00072BBC
		// Note: this type is marked as 'beforefieldinit'.
		static RestrictionFacets()
		{
			Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "RestrictionFacets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr);
			RestrictionFacets.NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "Length");
			RestrictionFacets.NativeFieldInfoPtr_MinLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "MinLength");
			RestrictionFacets.NativeFieldInfoPtr_MaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "MaxLength");
			RestrictionFacets.NativeFieldInfoPtr_Patterns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "Patterns");
			RestrictionFacets.NativeFieldInfoPtr_Enumeration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "Enumeration");
			RestrictionFacets.NativeFieldInfoPtr_WhiteSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "WhiteSpace");
			RestrictionFacets.NativeFieldInfoPtr_MaxInclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "MaxInclusive");
			RestrictionFacets.NativeFieldInfoPtr_MaxExclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "MaxExclusive");
			RestrictionFacets.NativeFieldInfoPtr_MinInclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "MinInclusive");
			RestrictionFacets.NativeFieldInfoPtr_MinExclusive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "MinExclusive");
			RestrictionFacets.NativeFieldInfoPtr_TotalDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "TotalDigits");
			RestrictionFacets.NativeFieldInfoPtr_FractionDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "FractionDigits");
			RestrictionFacets.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "Flags");
			RestrictionFacets.NativeFieldInfoPtr_FixedFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, "FixedFlags");
			RestrictionFacets.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr, 100666733);
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x00074B18 File Offset: 0x00072D18
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RestrictionFacets()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RestrictionFacets>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RestrictionFacets.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x0000A317 File Offset: 0x00008517
		public RestrictionFacets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x00074B54 File Offset: 0x00072D54
		// (set) Token: 0x060016F6 RID: 5878 RVA: 0x0000A320 File Offset: 0x00008520
		public unsafe int Length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_Length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_Length)) = value;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x060016F7 RID: 5879 RVA: 0x00074B7C File Offset: 0x00072D7C
		// (set) Token: 0x060016F8 RID: 5880 RVA: 0x0000A33B File Offset: 0x0000853B
		public unsafe int MinLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MinLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MinLength)) = value;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x060016F9 RID: 5881 RVA: 0x00074BA4 File Offset: 0x00072DA4
		// (set) Token: 0x060016FA RID: 5882 RVA: 0x0000A356 File Offset: 0x00008556
		public unsafe int MaxLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MaxLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MaxLength)) = value;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x060016FB RID: 5883 RVA: 0x00074BCC File Offset: 0x00072DCC
		// (set) Token: 0x060016FC RID: 5884 RVA: 0x0000A371 File Offset: 0x00008571
		public unsafe ArrayList Patterns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_Patterns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_Patterns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x060016FD RID: 5885 RVA: 0x00074BFC File Offset: 0x00072DFC
		// (set) Token: 0x060016FE RID: 5886 RVA: 0x0000A390 File Offset: 0x00008590
		public unsafe ArrayList Enumeration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_Enumeration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_Enumeration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x060016FF RID: 5887 RVA: 0x00074C2C File Offset: 0x00072E2C
		// (set) Token: 0x06001700 RID: 5888 RVA: 0x0000A3AF File Offset: 0x000085AF
		public unsafe XmlSchemaWhiteSpace WhiteSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_WhiteSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_WhiteSpace)) = value;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06001701 RID: 5889 RVA: 0x00074C54 File Offset: 0x00072E54
		// (set) Token: 0x06001702 RID: 5890 RVA: 0x0000A3CA File Offset: 0x000085CA
		public unsafe Object MaxInclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MaxInclusive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MaxInclusive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06001703 RID: 5891 RVA: 0x00074C84 File Offset: 0x00072E84
		// (set) Token: 0x06001704 RID: 5892 RVA: 0x0000A3E9 File Offset: 0x000085E9
		public unsafe Object MaxExclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MaxExclusive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MaxExclusive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06001705 RID: 5893 RVA: 0x00074CB4 File Offset: 0x00072EB4
		// (set) Token: 0x06001706 RID: 5894 RVA: 0x0000A408 File Offset: 0x00008608
		public unsafe Object MinInclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MinInclusive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MinInclusive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x00074CE4 File Offset: 0x00072EE4
		// (set) Token: 0x06001708 RID: 5896 RVA: 0x0000A427 File Offset: 0x00008627
		public unsafe Object MinExclusive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MinExclusive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_MinExclusive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001709 RID: 5897 RVA: 0x00074D14 File Offset: 0x00072F14
		// (set) Token: 0x0600170A RID: 5898 RVA: 0x0000A446 File Offset: 0x00008646
		public unsafe int TotalDigits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_TotalDigits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_TotalDigits)) = value;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x0600170B RID: 5899 RVA: 0x00074D3C File Offset: 0x00072F3C
		// (set) Token: 0x0600170C RID: 5900 RVA: 0x0000A461 File Offset: 0x00008661
		public unsafe int FractionDigits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_FractionDigits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_FractionDigits)) = value;
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x0600170D RID: 5901 RVA: 0x00074D64 File Offset: 0x00072F64
		// (set) Token: 0x0600170E RID: 5902 RVA: 0x0000A47C File Offset: 0x0000867C
		public unsafe RestrictionFlags Flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_Flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_Flags)) = value;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x0600170F RID: 5903 RVA: 0x00074D8C File Offset: 0x00072F8C
		// (set) Token: 0x06001710 RID: 5904 RVA: 0x0000A497 File Offset: 0x00008697
		public unsafe RestrictionFlags FixedFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_FixedFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RestrictionFacets.NativeFieldInfoPtr_FixedFlags)) = value;
			}
		}

		// Token: 0x0400117B RID: 4475
		private static readonly IntPtr NativeFieldInfoPtr_Length;

		// Token: 0x0400117C RID: 4476
		private static readonly IntPtr NativeFieldInfoPtr_MinLength;

		// Token: 0x0400117D RID: 4477
		private static readonly IntPtr NativeFieldInfoPtr_MaxLength;

		// Token: 0x0400117E RID: 4478
		private static readonly IntPtr NativeFieldInfoPtr_Patterns;

		// Token: 0x0400117F RID: 4479
		private static readonly IntPtr NativeFieldInfoPtr_Enumeration;

		// Token: 0x04001180 RID: 4480
		private static readonly IntPtr NativeFieldInfoPtr_WhiteSpace;

		// Token: 0x04001181 RID: 4481
		private static readonly IntPtr NativeFieldInfoPtr_MaxInclusive;

		// Token: 0x04001182 RID: 4482
		private static readonly IntPtr NativeFieldInfoPtr_MaxExclusive;

		// Token: 0x04001183 RID: 4483
		private static readonly IntPtr NativeFieldInfoPtr_MinInclusive;

		// Token: 0x04001184 RID: 4484
		private static readonly IntPtr NativeFieldInfoPtr_MinExclusive;

		// Token: 0x04001185 RID: 4485
		private static readonly IntPtr NativeFieldInfoPtr_TotalDigits;

		// Token: 0x04001186 RID: 4486
		private static readonly IntPtr NativeFieldInfoPtr_FractionDigits;

		// Token: 0x04001187 RID: 4487
		private static readonly IntPtr NativeFieldInfoPtr_Flags;

		// Token: 0x04001188 RID: 4488
		private static readonly IntPtr NativeFieldInfoPtr_FixedFlags;

		// Token: 0x04001189 RID: 4489
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
