using System;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000266 RID: 614
	[Serializable]
	public struct Pose
	{
		// Token: 0x060021FC RID: 8700 RVA: 0x000120C8 File Offset: 0x000102C8
		public override string ToString()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x000120D5 File Offset: 0x000102D5
		public string ToString(string format)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x000776A8 File Offset: 0x000758A8
		public Pose GetTransformedBy(Pose lhs)
		{
			return new Pose
			{
				position = lhs.position + lhs.rotation * this.position,
				rotation = lhs.rotation * this.rotation
			};
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x00077700 File Offset: 0x00075900
		public Pose GetTransformedBy(Transform lhs)
		{
			return new Pose
			{
				position = lhs.TransformPoint(this.position),
				rotation = lhs.rotation * this.rotation
			};
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06002200 RID: 8704 RVA: 0x00077748 File Offset: 0x00075948
		public Vector3 forward
		{
			get
			{
				return this.rotation * Vector3.forward;
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06002201 RID: 8705 RVA: 0x0007776C File Offset: 0x0007596C
		public Vector3 right
		{
			get
			{
				return this.rotation * Vector3.right;
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06002202 RID: 8706 RVA: 0x00077790 File Offset: 0x00075990
		public Vector3 up
		{
			get
			{
				return this.rotation * Vector3.up;
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06002203 RID: 8707 RVA: 0x000120E2 File Offset: 0x000102E2
		public static Pose identity
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x000777B4 File Offset: 0x000759B4
		public override bool Equals(Object obj)
		{
			bool flag = !(obj is Pose);
			return !flag && this.Equals((Pose)obj);
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x000777E8 File Offset: 0x000759E8
		public bool Equals(Pose other)
		{
			return this.position == other.position && this.rotation == other.rotation;
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x00077824 File Offset: 0x00075A24
		public override int GetHashCode()
		{
			return this.position.GetHashCode() ^ (this.rotation.GetHashCode() << 1);
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x0007785C File Offset: 0x00075A5C
		public static bool operator ==(Pose a, Pose b)
		{
			return a.Equals(b);
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x00077878 File Offset: 0x00075A78
		public static bool operator !=(Pose a, Pose b)
		{
			return !(a == b);
		}

		// Token: 0x04001C00 RID: 7168
		public Vector3 position;

		// Token: 0x04001C01 RID: 7169
		public Quaternion rotation;
	}
}
