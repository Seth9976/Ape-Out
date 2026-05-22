using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x020000F5 RID: 245
	public class GuardGrabbed : GuardMode
	{
		// Token: 0x06001CDD RID: 7389 RVA: 0x0008562C File Offset: 0x0008382C
		// Note: this type is marked as 'beforefieldinit'.
		static GuardGrabbed()
		{
			Il2CppClassPointerStore<GuardGrabbed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GuardGrabbed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuardGrabbed>.NativeClassPtr);
			GuardGrabbed.NativeFieldInfoPtr_aimRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGrabbed>.NativeClassPtr, "aimRight");
			GuardGrabbed.NativeFieldInfoPtr_waggleTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuardGrabbed>.NativeClassPtr, "waggleTimer");
			GuardGrabbed.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGrabbed>.NativeClassPtr, 100665636);
			GuardGrabbed.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGrabbed>.NativeClassPtr, 100665637);
			GuardGrabbed.NativeMethodInfoPtr_ShouldAnim_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGrabbed>.NativeClassPtr, 100665638);
			GuardGrabbed.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuardGrabbed>.NativeClassPtr, 100665639);
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x000856D4 File Offset: 0x000838D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63616, XrefRangeEnd = 63620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuardGrabbed(GuardState st)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuardGrabbed>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(st);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuardGrabbed.NativeMethodInfoPtr__ctor_Public_Void_GuardState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x00085720 File Offset: 0x00083920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63620, XrefRangeEnd = 63623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardGrabbed.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x0008575C File Offset: 0x0008395C
		[CallerCount(0)]
		public unsafe override bool ShouldAnim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardGrabbed.NativeMethodInfoPtr_ShouldAnim_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x000857A4 File Offset: 0x000839A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63623, XrefRangeEnd = 63640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuardGrabbed.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x0001452E File Offset: 0x0001272E
		public GuardGrabbed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x000857E0 File Offset: 0x000839E0
		// (set) Token: 0x06001CE4 RID: 7396 RVA: 0x00014537 File Offset: 0x00012737
		public unsafe bool aimRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGrabbed.NativeFieldInfoPtr_aimRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGrabbed.NativeFieldInfoPtr_aimRight)) = value;
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06001CE5 RID: 7397 RVA: 0x00085808 File Offset: 0x00083A08
		// (set) Token: 0x06001CE6 RID: 7398 RVA: 0x00014552 File Offset: 0x00012752
		public unsafe int waggleTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGrabbed.NativeFieldInfoPtr_waggleTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuardGrabbed.NativeFieldInfoPtr_waggleTimer)) = value;
			}
		}

		// Token: 0x04001127 RID: 4391
		private static readonly IntPtr NativeFieldInfoPtr_aimRight;

		// Token: 0x04001128 RID: 4392
		private static readonly IntPtr NativeFieldInfoPtr_waggleTimer;

		// Token: 0x04001129 RID: 4393
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuardState_0;

		// Token: 0x0400112A RID: 4394
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x0400112B RID: 4395
		private static readonly IntPtr NativeMethodInfoPtr_ShouldAnim_Public_Virtual_Boolean_0;

		// Token: 0x0400112C RID: 4396
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;
	}
}
