using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200025D RID: 605
	public sealed class CancellationCallbackCoreWorkArguments : ValueType
	{
		// Token: 0x06002A61 RID: 10849 RVA: 0x000DDEDC File Offset: 0x000DC0DC
		// Note: this type is marked as 'beforefieldinit'.
		static CancellationCallbackCoreWorkArguments()
		{
			Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "CancellationCallbackCoreWorkArguments");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr);
			CancellationCallbackCoreWorkArguments.NativeFieldInfoPtr_m_currArrayFragment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr, "m_currArrayFragment");
			CancellationCallbackCoreWorkArguments.NativeFieldInfoPtr_m_currArrayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr, "m_currArrayIndex");
			CancellationCallbackCoreWorkArguments.NativeMethodInfoPtr__ctor_Public_Void_SparselyPopulatedArrayFragment_1_CancellationCallbackInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr, 100670137);
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x000DDF48 File Offset: 0x000DC148
		[CallerCount(0)]
		public unsafe CancellationCallbackCoreWorkArguments(SparselyPopulatedArrayFragment<CancellationCallbackInfo> currArrayFragment, int currArrayIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currArrayFragment);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currArrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationCallbackCoreWorkArguments.NativeMethodInfoPtr__ctor_Public_Void_SparselyPopulatedArrayFragment_1_CancellationCallbackInfo_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x0000E97B File Offset: 0x0000CB7B
		public CancellationCallbackCoreWorkArguments(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002A64 RID: 10852 RVA: 0x0000E984 File Offset: 0x0000CB84
		public CancellationCallbackCoreWorkArguments()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr))
		{
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06002A65 RID: 10853 RVA: 0x000DDFA8 File Offset: 0x000DC1A8
		// (set) Token: 0x06002A66 RID: 10854 RVA: 0x0000E996 File Offset: 0x0000CB96
		public unsafe SparselyPopulatedArrayFragment<CancellationCallbackInfo> m_currArrayFragment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackCoreWorkArguments.NativeFieldInfoPtr_m_currArrayFragment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<CancellationCallbackInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackCoreWorkArguments.NativeFieldInfoPtr_m_currArrayFragment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06002A67 RID: 10855 RVA: 0x000DDFD8 File Offset: 0x000DC1D8
		// (set) Token: 0x06002A68 RID: 10856 RVA: 0x0000E9B5 File Offset: 0x0000CBB5
		public unsafe int m_currArrayIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackCoreWorkArguments.NativeFieldInfoPtr_m_currArrayIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackCoreWorkArguments.NativeFieldInfoPtr_m_currArrayIndex)) = value;
			}
		}

		// Token: 0x04002552 RID: 9554
		private static readonly IntPtr NativeFieldInfoPtr_m_currArrayFragment;

		// Token: 0x04002553 RID: 9555
		private static readonly IntPtr NativeFieldInfoPtr_m_currArrayIndex;

		// Token: 0x04002554 RID: 9556
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SparselyPopulatedArrayFragment_1_CancellationCallbackInfo_Int32_0;
	}
}
