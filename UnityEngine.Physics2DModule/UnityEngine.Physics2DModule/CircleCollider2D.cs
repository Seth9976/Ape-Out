using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000010 RID: 16
	public sealed class CircleCollider2D : Collider2D
	{
		// Token: 0x06000301 RID: 769 RVA: 0x0000C9E8 File Offset: 0x0000ABE8
		// Note: this type is marked as 'beforefieldinit'.
		static CircleCollider2D()
		{
			Il2CppClassPointerStore<CircleCollider2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "CircleCollider2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CircleCollider2D>.NativeClassPtr);
			CircleCollider2D.NativeMethodInfoPtr_get_radius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleCollider2D>.NativeClassPtr, 100663442);
			CircleCollider2D.NativeMethodInfoPtr_set_radius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircleCollider2D>.NativeClassPtr, 100663443);
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0000CA40 File Offset: 0x0000AC40
		// (set) Token: 0x06000303 RID: 771 RVA: 0x0000CA7C File Offset: 0x0000AC7C
		public unsafe float radius
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513469, XrefRangeEnd = 513473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleCollider2D.NativeMethodInfoPtr_get_radius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513473, XrefRangeEnd = 513477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircleCollider2D.NativeMethodInfoPtr_set_radius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00003275 File Offset: 0x00001475
		public CircleCollider2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_get_radius_Public_get_Single_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_set_radius_Public_set_Void_Single_0;
	}
}
