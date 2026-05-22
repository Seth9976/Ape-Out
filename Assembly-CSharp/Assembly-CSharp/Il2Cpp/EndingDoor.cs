using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000C3 RID: 195
	public class EndingDoor : MessageReceiver
	{
		// Token: 0x060016F2 RID: 5874 RVA: 0x00074FD0 File Offset: 0x000731D0
		// Note: this type is marked as 'beforefieldinit'.
		static EndingDoor()
		{
			Il2CppClassPointerStore<EndingDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "EndingDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndingDoor>.NativeClassPtr);
			EndingDoor.NativeFieldInfoPtr_freedomClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndingDoor>.NativeClassPtr, "freedomClips");
			EndingDoor.NativeMethodInfoPtr_OnPushed_Public_Virtual_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndingDoor>.NativeClassPtr, 100665215);
			EndingDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndingDoor>.NativeClassPtr, 100665216);
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x0007503C File Offset: 0x0007323C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56353, XrefRangeEnd = 56361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPushed(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EndingDoor.NativeMethodInfoPtr_OnPushed_Public_Virtual_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x00075088 File Offset: 0x00073288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56361, XrefRangeEnd = 56367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EndingDoor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndingDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndingDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x000107E0 File Offset: 0x0000E9E0
		public EndingDoor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x060016F6 RID: 5878 RVA: 0x000750C4 File Offset: 0x000732C4
		// (set) Token: 0x060016F7 RID: 5879 RVA: 0x000107E9 File Offset: 0x0000E9E9
		public unsafe Il2CppReferenceArray<AudioClip> freedomClips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndingDoor.NativeFieldInfoPtr_freedomClips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndingDoor.NativeFieldInfoPtr_freedomClips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DAE RID: 3502
		private static readonly IntPtr NativeFieldInfoPtr_freedomClips;

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeMethodInfoPtr_OnPushed_Public_Virtual_Void_Vector2_0;

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
