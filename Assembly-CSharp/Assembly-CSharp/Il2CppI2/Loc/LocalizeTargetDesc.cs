using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppI2.Loc
{
	// Token: 0x02000246 RID: 582
	public class LocalizeTargetDesc<T> : ILocalizeTargetDescriptor where T : ILocalizeTarget
	{
		// Token: 0x06004513 RID: 17683 RVA: 0x00100FC4 File Offset: 0x000FF1C4
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizeTargetDesc()
		{
			Il2CppClassPointerStore<LocalizeTargetDesc<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "LocalizeTargetDesc`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizeTargetDesc<T>>.NativeClassPtr);
			LocalizeTargetDesc<T>.NativeMethodInfoPtr_CreateTarget_Public_Virtual_ILocalizeTarget_Localize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTargetDesc<T>>.NativeClassPtr, 100670206);
			LocalizeTargetDesc<T>.NativeMethodInfoPtr_GetTargetType_Public_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTargetDesc<T>>.NativeClassPtr, 100670207);
			LocalizeTargetDesc<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeTargetDesc<T>>.NativeClassPtr, 100670208);
		}

		// Token: 0x06004514 RID: 17684 RVA: 0x0010106C File Offset: 0x000FF26C
		[CallerCount(0)]
		public unsafe override ILocalizeTarget CreateTarget(Localize cmp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTargetDesc<T>.NativeMethodInfoPtr_CreateTarget_Public_Virtual_ILocalizeTarget_Localize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILocalizeTarget>(intPtr3) : null;
			}
		}

		// Token: 0x06004515 RID: 17685 RVA: 0x001010C8 File Offset: 0x000FF2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112837, XrefRangeEnd = 112841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetTargetType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeTargetDesc<T>.NativeMethodInfoPtr_GetTargetType_Public_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06004516 RID: 17686 RVA: 0x00101114 File Offset: 0x000FF314
		[CallerCount(0)]
		public unsafe LocalizeTargetDesc()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizeTargetDesc<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeTargetDesc<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004517 RID: 17687 RVA: 0x0002988A File Offset: 0x00027A8A
		public LocalizeTargetDesc(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002AB9 RID: 10937
		private static readonly IntPtr NativeMethodInfoPtr_CreateTarget_Public_Virtual_ILocalizeTarget_Localize_0;

		// Token: 0x04002ABA RID: 10938
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetType_Public_Virtual_Type_0;

		// Token: 0x04002ABB RID: 10939
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
