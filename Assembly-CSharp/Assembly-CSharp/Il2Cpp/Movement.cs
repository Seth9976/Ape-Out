using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000132 RID: 306
	public class Movement : MonoBehaviour
	{
		// Token: 0x06002625 RID: 9765 RVA: 0x0009E2B0 File Offset: 0x0009C4B0
		// Note: this type is marked as 'beforefieldinit'.
		static Movement()
		{
			Il2CppClassPointerStore<Movement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Movement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Movement>.NativeClassPtr);
			Movement.NativeMethodInfoPtr_Wander_Public_Static_Vector2_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Movement>.NativeClassPtr, 100666334);
			Movement.NativeMethodInfoPtr_Reinforce_Public_Static_Vector2_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Movement>.NativeClassPtr, 100666335);
			Movement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Movement>.NativeClassPtr, 100666336);
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x0009E31C File Offset: 0x0009C51C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74251, RefRangeEnd = 74252, XrefRangeStart = 74247, XrefRangeEnd = 74251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 Wander(Vector2 pt, int stepNum = 100)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stepNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Movement.NativeMethodInfoPtr_Wander_Public_Static_Vector2_Vector2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x0009E368 File Offset: 0x0009C568
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 74258, RefRangeEnd = 74260, XrefRangeStart = 74252, XrefRangeEnd = 74258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 Reinforce(Vector2 pt, float xdist, float ydist)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xdist;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ydist;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Movement.NativeMethodInfoPtr_Reinforce_Public_Static_Vector2_Vector2_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x0009E3C4 File Offset: 0x0009C5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Movement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Movement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Movement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x0001AAF5 File Offset: 0x00018CF5
		public Movement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001684 RID: 5764
		private static readonly IntPtr NativeMethodInfoPtr_Wander_Public_Static_Vector2_Vector2_Int32_0;

		// Token: 0x04001685 RID: 5765
		private static readonly IntPtr NativeMethodInfoPtr_Reinforce_Public_Static_Vector2_Vector2_Single_Single_0;

		// Token: 0x04001686 RID: 5766
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
