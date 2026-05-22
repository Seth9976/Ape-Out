using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000F1 RID: 241
	public class GuardEndPush : GuardMode
	{
		// Token: 0x06001C8E RID: 7310 RVA: 0x0008490C File Offset: 0x00082B0C
		// Note: this type is marked as 'beforefieldinit'.
		static GuardEndPush()
		{
			Il2CppClassPointerStore<GuardEndPush>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardEndPush");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardEndPush>.NativeClassPtr);
			GuardEndPush.NativeFieldInfoPtr_pushDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardEndPush>.NativeClassPtr, "pushDir");
			GuardEndPush.NativeFieldInfoPtr_pushSpd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardEndPush>.NativeClassPtr, "pushSpd");
			GuardEndPush.NativeFieldInfoPtr_decelRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardEndPush>.NativeClassPtr, "decelRate");
			GuardEndPush.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardEndPush>.NativeClassPtr, 100665619);
			GuardEndPush.NativeMethodInfoPtr_ShouldAnim_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardEndPush>.NativeClassPtr, 100665620);
			GuardEndPush.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardEndPush>.NativeClassPtr, 100665621);
			GuardEndPush.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardEndPush>.NativeClassPtr, 100665622);
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x000849C8 File Offset: 0x00082BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63440, XrefRangeEnd = 63444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuardEndPush(GuardState st)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardEndPush>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardEndPush.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x00084A14 File Offset: 0x00082C14
		[CallerCount(0)]
		public unsafe override bool ShouldAnim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardEndPush.NativeMethodInfoPtr_ShouldAnim_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x00084A5C File Offset: 0x00082C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63444, XrefRangeEnd = 63449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardEndPush.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x00084A98 File Offset: 0x00082C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63449, XrefRangeEnd = 63451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardEndPush.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x000141FF File Offset: 0x000123FF
		public GuardEndPush(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06001C94 RID: 7316 RVA: 0x00084AD4 File Offset: 0x00082CD4
		// (set) Token: 0x06001C95 RID: 7317 RVA: 0x00014208 File Offset: 0x00012408
		public unsafe Vector2 pushDir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardEndPush.NativeFieldInfoPtr_pushDir);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardEndPush.NativeFieldInfoPtr_pushDir)) = value;
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06001C96 RID: 7318 RVA: 0x00084AFC File Offset: 0x00082CFC
		// (set) Token: 0x06001C97 RID: 7319 RVA: 0x00014223 File Offset: 0x00012423
		public unsafe float pushSpd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardEndPush.NativeFieldInfoPtr_pushSpd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardEndPush.NativeFieldInfoPtr_pushSpd)) = value;
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06001C98 RID: 7320 RVA: 0x00084B24 File Offset: 0x00082D24
		// (set) Token: 0x06001C99 RID: 7321 RVA: 0x0001423E File Offset: 0x0001243E
		public unsafe float decelRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardEndPush.NativeFieldInfoPtr_decelRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardEndPush.NativeFieldInfoPtr_decelRate)) = value;
			}
		}

		// Token: 0x040010FB RID: 4347
		private static readonly IntPtr NativeFieldInfoPtr_pushDir;

		// Token: 0x040010FC RID: 4348
		private static readonly IntPtr NativeFieldInfoPtr_pushSpd;

		// Token: 0x040010FD RID: 4349
		private static readonly IntPtr NativeFieldInfoPtr_decelRate;

		// Token: 0x040010FE RID: 4350
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_0;

		// Token: 0x040010FF RID: 4351
		private static readonly IntPtr NativeMethodInfoPtr_ShouldAnim_Public_Virtual_Boolean_0;

		// Token: 0x04001100 RID: 4352
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04001101 RID: 4353
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;
	}
}
