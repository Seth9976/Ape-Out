using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000FD RID: 253
	public class GuardPanicking : GuardMode
	{
		// Token: 0x06001DA5 RID: 7589 RVA: 0x000879D0 File Offset: 0x00085BD0
		// Note: this type is marked as 'beforefieldinit'.
		static GuardPanicking()
		{
			Il2CppClassPointerStore<GuardPanicking>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardPanicking");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardPanicking>.NativeClassPtr);
			GuardPanicking.NativeFieldInfoPtr_aimPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardPanicking>.NativeClassPtr, "aimPos");
			GuardPanicking.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardPanicking>.NativeClassPtr, 100665690);
			GuardPanicking.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardPanicking>.NativeClassPtr, 100665691);
			GuardPanicking.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardPanicking>.NativeClassPtr, 100665692);
			GuardPanicking.NativeMethodInfoPtr_GetAim_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardPanicking>.NativeClassPtr, 100665693);
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x00087A64 File Offset: 0x00085C64
		[CallerCount(0)]
		public unsafe GuardPanicking(GuardState st)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardPanicking>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardPanicking.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x00087AB0 File Offset: 0x00085CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64584, XrefRangeEnd = 64585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardPanicking.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x00087AEC File Offset: 0x00085CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64585, XrefRangeEnd = 64622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardPanicking.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x00087B28 File Offset: 0x00085D28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 64628, RefRangeEnd = 64630, XrefRangeStart = 64622, XrefRangeEnd = 64628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetAim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardPanicking.NativeMethodInfoPtr_GetAim_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x00014CAC File Offset: 0x00012EAC
		public GuardPanicking(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06001DAB RID: 7595 RVA: 0x00087B5C File Offset: 0x00085D5C
		// (set) Token: 0x06001DAC RID: 7596 RVA: 0x00014CB5 File Offset: 0x00012EB5
		public unsafe Vector2 aimPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardPanicking.NativeFieldInfoPtr_aimPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardPanicking.NativeFieldInfoPtr_aimPos)) = value;
			}
		}

		// Token: 0x0400119E RID: 4510
		private static readonly IntPtr NativeFieldInfoPtr_aimPos;

		// Token: 0x0400119F RID: 4511
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_0;

		// Token: 0x040011A0 RID: 4512
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x040011A1 RID: 4513
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x040011A2 RID: 4514
		private static readonly IntPtr NativeMethodInfoPtr_GetAim_Public_Void_0;
	}
}
