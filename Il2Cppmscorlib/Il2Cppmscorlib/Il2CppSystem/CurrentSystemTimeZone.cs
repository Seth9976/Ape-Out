using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200013C RID: 316
	[Serializable]
	public class CurrentSystemTimeZone : TimeZone
	{
		// Token: 0x060016DB RID: 5851 RVA: 0x0008B720 File Offset: 0x00089920
		// Note: this type is marked as 'beforefieldinit'.
		static CurrentSystemTimeZone()
		{
			Il2CppClassPointerStore<CurrentSystemTimeZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "CurrentSystemTimeZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurrentSystemTimeZone>.NativeClassPtr);
			CurrentSystemTimeZone.NativeFieldInfoPtr_LocalTimeZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentSystemTimeZone>.NativeClassPtr, "LocalTimeZone");
			CurrentSystemTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurrentSystemTimeZone>.NativeClassPtr, 100667200);
			CurrentSystemTimeZone.NativeMethodInfoPtr_GetTimeZoneData_Public_Static_Boolean_Int32_byref_Il2CppStructArray_1_Int64_byref_Il2CppStringArray_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurrentSystemTimeZone>.NativeClassPtr, 100667201);
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x0008B78C File Offset: 0x0008998C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178518, XrefRangeEnd = 178522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CurrentSystemTimeZone()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurrentSystemTimeZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurrentSystemTimeZone.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x0008B7C8 File Offset: 0x000899C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178522, XrefRangeEnd = 178532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetTimeZoneData(int year, out Il2CppStructArray<long> data, out Il2CppStringArray names, out bool daylight_inverted)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &daylight_inverted;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(CurrentSystemTimeZone.NativeMethodInfoPtr_GetTimeZoneData_Public_Static_Boolean_Int32_byref_Il2CppStructArray_1_Int64_byref_Il2CppStringArray_byref_Boolean_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			data = ((intPtr5 == 0) ? null : new Il2CppStructArray<long>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			names = ((intPtr6 == 0) ? null : new Il2CppStringArray(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x00007E37 File Offset: 0x00006037
		public CurrentSystemTimeZone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060016DF RID: 5855 RVA: 0x0008B85C File Offset: 0x00089A5C
		// (set) Token: 0x060016E0 RID: 5856 RVA: 0x00007E40 File Offset: 0x00006040
		public unsafe TimeZoneInfo LocalTimeZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurrentSystemTimeZone.NativeFieldInfoPtr_LocalTimeZone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeZoneInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurrentSystemTimeZone.NativeFieldInfoPtr_LocalTimeZone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001508 RID: 5384
		private static readonly IntPtr NativeFieldInfoPtr_LocalTimeZone;

		// Token: 0x04001509 RID: 5385
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400150A RID: 5386
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeZoneData_Public_Static_Boolean_Int32_byref_Il2CppStructArray_1_Int64_byref_Il2CppStringArray_byref_Boolean_0;
	}
}
