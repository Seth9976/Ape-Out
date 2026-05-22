using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200005C RID: 92
	public class MatchSparse : Match
	{
		// Token: 0x0600060F RID: 1551 RVA: 0x00027FD4 File Offset: 0x000261D4
		// Note: this type is marked as 'beforefieldinit'.
		static MatchSparse()
		{
			Il2CppClassPointerStore<MatchSparse>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "MatchSparse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchSparse>.NativeClassPtr);
			MatchSparse.NativeFieldInfoPtr__caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchSparse>.NativeClassPtr, "_caps");
			MatchSparse.NativeMethodInfoPtr__ctor_Internal_Void_Regex_Hashtable_Int32_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchSparse>.NativeClassPtr, 100664229);
			MatchSparse.NativeMethodInfoPtr_get_Groups_Public_Virtual_get_GroupCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchSparse>.NativeClassPtr, 100664230);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00028040 File Offset: 0x00026240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 370998, XrefRangeEnd = 371002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchSparse(Regex regex, Hashtable caps, int capcount, string text, int begpos, int len, int startpos)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchSparse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caps);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capcount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref begpos;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startpos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchSparse.NativeMethodInfoPtr__ctor_Internal_Void_Regex_Hashtable_Int32_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x000280E8 File Offset: 0x000262E8
		public unsafe override GroupCollection Groups
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371002, XrefRangeEnd = 371006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MatchSparse.NativeMethodInfoPtr_get_Groups_Public_Virtual_get_GroupCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GroupCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0000448F File Offset: 0x0000268F
		public MatchSparse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x00028134 File Offset: 0x00026334
		// (set) Token: 0x06000614 RID: 1556 RVA: 0x00004498 File Offset: 0x00002698
		public new unsafe Hashtable _caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchSparse.NativeFieldInfoPtr__caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchSparse.NativeFieldInfoPtr__caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeFieldInfoPtr__caps;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Regex_Hashtable_Int32_String_Int32_Int32_Int32_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_get_Groups_Public_Virtual_get_GroupCollection_0;
	}
}
