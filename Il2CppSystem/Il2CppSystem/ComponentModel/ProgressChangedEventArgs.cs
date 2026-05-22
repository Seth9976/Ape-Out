using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200008E RID: 142
	public class ProgressChangedEventArgs : EventArgs
	{
		// Token: 0x060008C5 RID: 2245 RVA: 0x000315F4 File Offset: 0x0002F7F4
		// Note: this type is marked as 'beforefieldinit'.
		static ProgressChangedEventArgs()
		{
			Il2CppClassPointerStore<ProgressChangedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ProgressChangedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressChangedEventArgs>.NativeClassPtr);
			ProgressChangedEventArgs.NativeFieldInfoPtr_progressPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressChangedEventArgs>.NativeClassPtr, "progressPercentage");
			ProgressChangedEventArgs.NativeFieldInfoPtr_userState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressChangedEventArgs>.NativeClassPtr, "userState");
			ProgressChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressChangedEventArgs>.NativeClassPtr, 100664551);
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00031660 File Offset: 0x0002F860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372849, XrefRangeEnd = 372852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProgressChangedEventArgs(int progressPercentage, Object userState)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProgressChangedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref progressPercentage;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(userState);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProgressChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x0000582A File Offset: 0x00003A2A
		public ProgressChangedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x000316BC File Offset: 0x0002F8BC
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x00005833 File Offset: 0x00003A33
		public unsafe int progressPercentage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressChangedEventArgs.NativeFieldInfoPtr_progressPercentage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressChangedEventArgs.NativeFieldInfoPtr_progressPercentage)) = value;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x000316E4 File Offset: 0x0002F8E4
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x0000584E File Offset: 0x00003A4E
		public unsafe Object userState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressChangedEventArgs.NativeFieldInfoPtr_userState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressChangedEventArgs.NativeFieldInfoPtr_userState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeFieldInfoPtr_progressPercentage;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeFieldInfoPtr_userState;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_0;
	}
}
