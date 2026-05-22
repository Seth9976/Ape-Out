using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppI2.Loc
{
	// Token: 0x02000245 RID: 581
	public class ILocalizeTargetDescriptor : Object
	{
		// Token: 0x06004509 RID: 17673 RVA: 0x00100D90 File Offset: 0x000FEF90
		// Note: this type is marked as 'beforefieldinit'.
		static ILocalizeTargetDescriptor()
		{
			Il2CppClassPointerStore<ILocalizeTargetDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "ILocalizeTargetDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ILocalizeTargetDescriptor>.NativeClassPtr);
			ILocalizeTargetDescriptor.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ILocalizeTargetDescriptor>.NativeClassPtr, "Name");
			ILocalizeTargetDescriptor.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ILocalizeTargetDescriptor>.NativeClassPtr, "Priority");
			ILocalizeTargetDescriptor.NativeMethodInfoPtr_CanLocalize_Public_Abstract_Virtual_New_Boolean_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizeTargetDescriptor>.NativeClassPtr, 100670202);
			ILocalizeTargetDescriptor.NativeMethodInfoPtr_CreateTarget_Public_Abstract_Virtual_New_ILocalizeTarget_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizeTargetDescriptor>.NativeClassPtr, 100670203);
			ILocalizeTargetDescriptor.NativeMethodInfoPtr_GetTargetType_Public_Abstract_Virtual_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizeTargetDescriptor>.NativeClassPtr, 100670204);
			ILocalizeTargetDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizeTargetDescriptor>.NativeClassPtr, 100670205);
		}

		// Token: 0x0600450A RID: 17674 RVA: 0x00100E38 File Offset: 0x000FF038
		[CallerCount(0)]
		public unsafe virtual bool CanLocalize(Localize cmp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizeTargetDescriptor.NativeMethodInfoPtr_CanLocalize_Public_Abstract_Virtual_New_Boolean_Localize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600450B RID: 17675 RVA: 0x00100E90 File Offset: 0x000FF090
		[CallerCount(0)]
		public unsafe virtual ILocalizeTarget CreateTarget(Localize cmp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizeTargetDescriptor.NativeMethodInfoPtr_CreateTarget_Public_Abstract_Virtual_New_ILocalizeTarget_Localize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILocalizeTarget>(intPtr3) : null;
			}
		}

		// Token: 0x0600450C RID: 17676 RVA: 0x00100EEC File Offset: 0x000FF0EC
		[CallerCount(0)]
		public unsafe virtual Type GetTargetType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizeTargetDescriptor.NativeMethodInfoPtr_GetTargetType_Public_Abstract_Virtual_New_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x0600450D RID: 17677 RVA: 0x00100F38 File Offset: 0x000FF138
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ILocalizeTargetDescriptor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ILocalizeTargetDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ILocalizeTargetDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600450E RID: 17678 RVA: 0x00029847 File Offset: 0x00027A47
		public ILocalizeTargetDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001997 RID: 6551
		// (get) Token: 0x0600450F RID: 17679 RVA: 0x00100F74 File Offset: 0x000FF174
		// (set) Token: 0x06004510 RID: 17680 RVA: 0x00029850 File Offset: 0x00027A50
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILocalizeTargetDescriptor.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILocalizeTargetDescriptor.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001998 RID: 6552
		// (get) Token: 0x06004511 RID: 17681 RVA: 0x00100F9C File Offset: 0x000FF19C
		// (set) Token: 0x06004512 RID: 17682 RVA: 0x0002986F File Offset: 0x00027A6F
		public unsafe int Priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILocalizeTargetDescriptor.NativeFieldInfoPtr_Priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ILocalizeTargetDescriptor.NativeFieldInfoPtr_Priority)) = value;
			}
		}

		// Token: 0x04002AB3 RID: 10931
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04002AB4 RID: 10932
		private static readonly IntPtr NativeFieldInfoPtr_Priority;

		// Token: 0x04002AB5 RID: 10933
		private static readonly IntPtr NativeMethodInfoPtr_CanLocalize_Public_Abstract_Virtual_New_Boolean_Localize_0;

		// Token: 0x04002AB6 RID: 10934
		private static readonly IntPtr NativeMethodInfoPtr_CreateTarget_Public_Abstract_Virtual_New_ILocalizeTarget_Localize_0;

		// Token: 0x04002AB7 RID: 10935
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetType_Public_Abstract_Virtual_New_Type_0;

		// Token: 0x04002AB8 RID: 10936
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
