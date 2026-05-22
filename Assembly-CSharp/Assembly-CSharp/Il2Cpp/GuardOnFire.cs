using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000FC RID: 252
	public class GuardOnFire : GuardMode
	{
		// Token: 0x06001D9D RID: 7581 RVA: 0x000877E4 File Offset: 0x000859E4
		// Note: this type is marked as 'beforefieldinit'.
		static GuardOnFire()
		{
			Il2CppClassPointerStore<GuardOnFire>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardOnFire");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardOnFire>.NativeClassPtr);
			GuardOnFire.NativeFieldInfoPtr_goVect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardOnFire>.NativeClassPtr, "goVect");
			GuardOnFire.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardOnFire>.NativeClassPtr, 100665686);
			GuardOnFire.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardOnFire>.NativeClassPtr, 100665687);
			GuardOnFire.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardOnFire>.NativeClassPtr, 100665688);
			GuardOnFire.NativeMethodInfoPtr_OnCollEnter_Public_Virtual_Void_Collision2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardOnFire>.NativeClassPtr, 100665689);
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x00087878 File Offset: 0x00085A78
		[CallerCount(0)]
		public unsafe GuardOnFire(GuardState st, float mSpd, float rRate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardOnFire>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardOnFire.NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x000878E0 File Offset: 0x00085AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64556, XrefRangeEnd = 64566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardOnFire.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x0008791C File Offset: 0x00085B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64566, XrefRangeEnd = 64576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardOnFire.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00087958 File Offset: 0x00085B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64576, XrefRangeEnd = 64584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCollEnter(Collision2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardOnFire.NativeMethodInfoPtr_OnCollEnter_Public_Virtual_Void_Collision2D_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x00014C88 File Offset: 0x00012E88
		public GuardOnFire(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x000879A8 File Offset: 0x00085BA8
		// (set) Token: 0x06001DA4 RID: 7588 RVA: 0x00014C91 File Offset: 0x00012E91
		public unsafe Vector2 goVect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardOnFire.NativeFieldInfoPtr_goVect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardOnFire.NativeFieldInfoPtr_goVect)) = value;
			}
		}

		// Token: 0x04001199 RID: 4505
		private static readonly IntPtr NativeFieldInfoPtr_goVect;

		// Token: 0x0400119A RID: 4506
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_Single_Single_0;

		// Token: 0x0400119B RID: 4507
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x0400119C RID: 4508
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x0400119D RID: 4509
		private static readonly IntPtr NativeMethodInfoPtr_OnCollEnter_Public_Virtual_Void_Collision2D_0;
	}
}
