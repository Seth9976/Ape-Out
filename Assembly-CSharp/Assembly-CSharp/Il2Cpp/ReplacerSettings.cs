using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200016F RID: 367
	public class ReplacerSettings : ScriptableObject
	{
		// Token: 0x06002C08 RID: 11272 RVA: 0x000ADED8 File Offset: 0x000AC0D8
		// Note: this type is marked as 'beforefieldinit'.
		static ReplacerSettings()
		{
			Il2CppClassPointerStore<ReplacerSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ReplacerSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplacerSettings>.NativeClassPtr);
			ReplacerSettings.NativeFieldInfoPtr_lastObjCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplacerSettings>.NativeClassPtr, "lastObjCount");
			ReplacerSettings.NativeFieldInfoPtr_lastObjs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplacerSettings>.NativeClassPtr, "lastObjs");
			ReplacerSettings.NativeFieldInfoPtr_lastStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplacerSettings>.NativeClassPtr, "lastStrings");
			ReplacerSettings.NativeFieldInfoPtr_lastOmitsWiths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplacerSettings>.NativeClassPtr, "lastOmitsWiths");
			ReplacerSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplacerSettings>.NativeClassPtr, 100666748);
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x000ADF6C File Offset: 0x000AC16C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReplacerSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplacerSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReplacerSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x0001E876 File Offset: 0x0001CA76
		public ReplacerSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x06002C0B RID: 11275 RVA: 0x000ADFA8 File Offset: 0x000AC1A8
		// (set) Token: 0x06002C0C RID: 11276 RVA: 0x0001E87F File Offset: 0x0001CA7F
		public unsafe int lastObjCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplacerSettings.NativeFieldInfoPtr_lastObjCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplacerSettings.NativeFieldInfoPtr_lastObjCount)) = value;
			}
		}

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x06002C0D RID: 11277 RVA: 0x000ADFD0 File Offset: 0x000AC1D0
		// (set) Token: 0x06002C0E RID: 11278 RVA: 0x0001E89A File Offset: 0x0001CA9A
		public unsafe List<GameObject> lastObjs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplacerSettings.NativeFieldInfoPtr_lastObjs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplacerSettings.NativeFieldInfoPtr_lastObjs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x06002C0F RID: 11279 RVA: 0x000AE000 File Offset: 0x000AC200
		// (set) Token: 0x06002C10 RID: 11280 RVA: 0x0001E8B9 File Offset: 0x0001CAB9
		public unsafe List<string> lastStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplacerSettings.NativeFieldInfoPtr_lastStrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplacerSettings.NativeFieldInfoPtr_lastStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x06002C11 RID: 11281 RVA: 0x000AE030 File Offset: 0x000AC230
		// (set) Token: 0x06002C12 RID: 11282 RVA: 0x0001E8D8 File Offset: 0x0001CAD8
		public unsafe List<string> lastOmitsWiths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplacerSettings.NativeFieldInfoPtr_lastOmitsWiths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReplacerSettings.NativeFieldInfoPtr_lastOmitsWiths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019F3 RID: 6643
		private static readonly IntPtr NativeFieldInfoPtr_lastObjCount;

		// Token: 0x040019F4 RID: 6644
		private static readonly IntPtr NativeFieldInfoPtr_lastObjs;

		// Token: 0x040019F5 RID: 6645
		private static readonly IntPtr NativeFieldInfoPtr_lastStrings;

		// Token: 0x040019F6 RID: 6646
		private static readonly IntPtr NativeFieldInfoPtr_lastOmitsWiths;

		// Token: 0x040019F7 RID: 6647
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
