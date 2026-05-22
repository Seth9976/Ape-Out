using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000EE RID: 238
	public class GuardChasing : GuardMode
	{
		// Token: 0x06001C59 RID: 7257 RVA: 0x00083EE0 File Offset: 0x000820E0
		// Note: this type is marked as 'beforefieldinit'.
		static GuardChasing()
		{
			Il2CppClassPointerStore<GuardChasing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardChasing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardChasing>.NativeClassPtr);
			GuardChasing.NativeFieldInfoPtr_dest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardChasing>.NativeClassPtr, "dest");
			GuardChasing.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardChasing>.NativeClassPtr, "timer");
			GuardChasing.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardChasing>.NativeClassPtr, 100665602);
			GuardChasing.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardChasing>.NativeClassPtr, 100665603);
			GuardChasing.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardChasing>.NativeClassPtr, 100665604);
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x00083F74 File Offset: 0x00082174
		[CallerCount(0)]
		public unsafe GuardChasing(GuardState st, float mSpd, float rRate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardChasing>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mSpd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardChasing.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x00083FDC File Offset: 0x000821DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 62933, RefRangeEnd = 62934, XrefRangeStart = 62892, XrefRangeEnd = 62933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardChasing.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x00084018 File Offset: 0x00082218
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 62937, RefRangeEnd = 62938, XrefRangeStart = 62934, XrefRangeEnd = 62937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardChasing.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x00013FFE File Offset: 0x000121FE
		public GuardChasing(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06001C5E RID: 7262 RVA: 0x00084054 File Offset: 0x00082254
		// (set) Token: 0x06001C5F RID: 7263 RVA: 0x00014007 File Offset: 0x00012207
		public unsafe Vector2 dest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardChasing.NativeFieldInfoPtr_dest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardChasing.NativeFieldInfoPtr_dest)) = value;
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06001C60 RID: 7264 RVA: 0x0008407C File Offset: 0x0008227C
		// (set) Token: 0x06001C61 RID: 7265 RVA: 0x00014022 File Offset: 0x00012222
		public unsafe int timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardChasing.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardChasing.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x040010DB RID: 4315
		private static readonly IntPtr NativeFieldInfoPtr_dest;

		// Token: 0x040010DC RID: 4316
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x040010DD RID: 4317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0;

		// Token: 0x040010DE RID: 4318
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x040010DF RID: 4319
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;
	}
}
