using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000C4 RID: 196
	public class EnemyState : MonoBehaviour
	{
		// Token: 0x060016F8 RID: 5880 RVA: 0x000750F4 File Offset: 0x000732F4
		// Note: this type is marked as 'beforefieldinit'.
		static EnemyState()
		{
			Il2CppClassPointerStore<EnemyState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "EnemyState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnemyState>.NativeClassPtr);
			EnemyState.NativeFieldInfoPtr_pushed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyState>.NativeClassPtr, "pushed");
			EnemyState.NativeFieldInfoPtr_grabbed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyState>.NativeClassPtr, "grabbed");
			EnemyState.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyState>.NativeClassPtr, 100665217);
			EnemyState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyState>.NativeClassPtr, 100665218);
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x00075174 File Offset: 0x00073374
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnemyState.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x000751A8 File Offset: 0x000733A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnemyState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnemyState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnemyState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x00010808 File Offset: 0x0000EA08
		public EnemyState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x060016FC RID: 5884 RVA: 0x000751E4 File Offset: 0x000733E4
		// (set) Token: 0x060016FD RID: 5885 RVA: 0x00010811 File Offset: 0x0000EA11
		public unsafe bool pushed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnemyState.NativeFieldInfoPtr_pushed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnemyState.NativeFieldInfoPtr_pushed)) = value;
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x060016FE RID: 5886 RVA: 0x0007520C File Offset: 0x0007340C
		// (set) Token: 0x060016FF RID: 5887 RVA: 0x0001082C File Offset: 0x0000EA2C
		public unsafe bool grabbed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnemyState.NativeFieldInfoPtr_grabbed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnemyState.NativeFieldInfoPtr_grabbed)) = value;
			}
		}

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeFieldInfoPtr_pushed;

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeFieldInfoPtr_grabbed;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000DB4 RID: 3508
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
